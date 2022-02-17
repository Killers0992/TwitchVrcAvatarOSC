using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace BlobHandles
{
    /// <summary>
    /// Represents a string as a fixed blob of bytes
    /// </summary>
    public struct BlobString : IDisposable, IEquatable<BlobString>
    {
        /// <summary>
        /// The encoding used to convert to and from strings.
        /// WARNING - Changing this after strings have been encoded will probably lead to errors!
        /// </summary>
        public static Encoding Encoding { get; set; } = Encoding.ASCII;
        
        // Stores all of the bytes that represent this string
        readonly byte[] Bytes; 
        
        public readonly BlobHandle Handle;

        public int Length => Bytes.Length;
        
        public unsafe BlobString(string source)
        {
            var byteCount = Encoding.GetByteCount(source);
            Bytes = new byte[byteCount];

            var nativeBytesPtr = (byte*)Marshal.UnsafeAddrOfPinnedArrayElement(Bytes, 0);
            
            // write encoded string bytes directly to unmanaged memory
            fixed (char* strPtr = source)
            {
                Encoding.GetBytes(strPtr, source.Length, nativeBytesPtr, byteCount);
                Handle = new BlobHandle(nativeBytesPtr, byteCount);
            }
        }
        
        public unsafe BlobString(byte* sourcePtr, int length)
        {
            Handle = new BlobHandle(sourcePtr, length);
            Bytes = default;
        }
                
        public override unsafe string ToString()
        {
            return Encoding.GetString(Handle.Pointer, Handle.Length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(BlobString other)
        {
            return Handle.Equals(other.Handle);
        }
        
        public override bool Equals(object obj)
        {
            return obj is BlobString other && Handle.Equals(other.Handle);
        }

        public static bool operator ==(BlobString l, BlobString r)
        {
            return l.Handle == r.Handle;
        }

        public static bool operator !=(BlobString l, BlobString r)
        {
            return l.Handle != r.Handle;
        }
        
        public void Dispose()
        {
        }
    }
}
