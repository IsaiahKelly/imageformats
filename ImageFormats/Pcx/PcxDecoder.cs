using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using System.IO;
using System.Threading;

namespace DmitryBrant.ImageFormats.Pcx;

internal class PcxDecoder : ImageDecoder
{
    private PcxDecoder()
    {
    }

    /// <summary>
    /// Gets the shared instance.
    /// </summary>
    public static PcxDecoder Instance { get; } = new();

    protected override Image<TPixel> Decode<TPixel>(DecoderOptions options, Stream stream, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }

    protected override Image Decode(DecoderOptions options, Stream stream, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }

    protected override ImageInfo Identify(DecoderOptions options, Stream stream, CancellationToken cancellationToken)
    {
        throw new System.NotImplementedException();
    }
}

