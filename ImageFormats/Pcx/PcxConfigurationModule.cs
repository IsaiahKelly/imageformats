using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

namespace DmitryBrant.ImageFormats.Pcx;

/// <summary>
/// Registers the image encoders, decoders and mime type detectors for the PCX format.
/// </summary>
public sealed class PcxConfigurationModule : IImageFormatConfigurationModule
{
    /// <inheritdoc/>
    public void Configure(Configuration configuration)
    {
        configuration.ImageFormatsManager.SetDecoder(PcxFormat.Instance, PcxDecoder.Instance);
        configuration.ImageFormatsManager.AddImageFormatDetector(new PcxFormatDetector());
    }
}