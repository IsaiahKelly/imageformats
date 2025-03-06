using System.Collections.Generic;

namespace DmitryBrant.ImageFormats.Pcx;

/// <summary>
/// Defines constants relating to PCXs
/// </summary>
internal static class PcxConstants
{
    /// <summary>
    /// The list of mimetypes that equate to a PCX.
    /// </summary>
    public static readonly IEnumerable<string> MimeTypes = new[]
    {
        "image/vnd.zbrush.pcx",
        "image/x-pcx"
    };

    /// <summary>
    /// The list of file extensions that equate to a PCX.
    /// </summary>
    public static readonly IEnumerable<string> FileExtensions = new[] { "pcx" };

    /// <summary>
    /// Valid magic bytes markers identifying a PCX file.
    /// </summary>
    internal static class TypeMarkers
    {
        // TODO: Add actual PCX file type markers.
    }
}