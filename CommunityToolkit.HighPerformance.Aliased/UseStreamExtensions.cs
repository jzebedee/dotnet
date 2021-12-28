using System;
using System.IO;

namespace CommunityToolkit.HighPerformance.Aliased
{
    public static class UseStreamExtensions
    {
        public static void WriteExtension(this Stream stream, ReadOnlySpan<byte> span) => stream.Write(span);
        public static void ReadExtension(this Stream stream, Span<byte> span) => stream.Read(span);
    }
}
