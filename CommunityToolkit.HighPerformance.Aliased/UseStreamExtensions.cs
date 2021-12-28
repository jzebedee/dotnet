using System;
using System.IO;

namespace CommunityToolkit.HighPerformance.Aliased;

/// <summary>
/// Extension class to explicitly use the CT.HP extensions
/// </summary>
public static class UseStreamExtensions
{
    /// <summary>
    /// Explicit call using the CT.HP Stream.Write extension
    /// </summary>
    public static void WriteExtension(this Stream stream, ReadOnlySpan<byte> span) => stream.Write(span);
    /// <summary>
    /// Explicit call using the CT.HP Stream.Read extension
    /// </summary>
    public static void ReadExtension(this Stream stream, Span<byte> span) => stream.Read(span);
}
