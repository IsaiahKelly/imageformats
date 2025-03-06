using SixLabors.ImageSharp.Formats;
using System;
using System.Buffers.Binary;
using System.Diagnostics.CodeAnalysis;

namespace DmitryBrant.ImageFormats.Pcx;

/// <summary>
/// Detects PCX file headers.
/// </summary>
public sealed class PcxFormatDetector : IImageFormatDetector
{
    /// <inheritdoc/>
    public int HeaderSize => 2;

    /// <inheritdoc/>
    public bool TryDetectFormat(ReadOnlySpan<byte> header, [NotNullWhen(true)] out IImageFormat? format)
    {
        format = this.IsSupportedFileFormat(header) ? PcxFormat.Instance : null;

        return format != null;
    }

    private bool IsSupportedFileFormat(ReadOnlySpan<byte> header)
    {
        if (header.Length >= this.HeaderSize)
        {
            // TODO: Replace with PCX file type markers.
            return ((header[0] == 0xA) && (header[1] <= 0x5) && (header[2] == 0x1) && ((header[3] == 0x1) || (header[3] == 0x2) || (header[3] == 0x4) || (header[3] == 0x8)));
        }

        return false;
    }
}