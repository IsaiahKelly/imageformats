using SixLabors.ImageSharp.Formats;
using System.Collections.Generic;

namespace DmitryBrant.ImageFormats.Pcx;

/// <summary>
/// Registers the image encoders, decoders and mime type detectors for the PCX format.
/// </summary>
public sealed class PcxFormat : IImageFormat
{
    private PcxFormat()
    {
    }

    /// <summary>
    /// Gets the shared instance.
    /// </summary>
    public static PcxFormat Instance { get; } = new PcxFormat();

    /// <inheritdoc/>
    public string Name => "PCX";

    /// <inheritdoc/>
    public string DefaultMimeType => "image/vnd.zbrush.pcx";

    /// <inheritdoc/>
    public IEnumerable<string> MimeTypes => PcxConstants.MimeTypes;

    /// <inheritdoc/>
    public IEnumerable<string> FileExtensions => PcxConstants.FileExtensions;

    /// <inheritdoc/>
    public PcxMetadata CreateDefaultFormatMetadata() => new();
}