using System;

namespace YngveHestem.BytesViewer.Blazor.Core;

public static class Extensions
{
    /// <summary>
    /// Returns the first IByteView which can show the given mime-type/extension/bytes.
    /// </summary>
    /// <param name="items">The IByteViews to check for</param>
    /// <param name="mimeType">The given mime type.</param>
    /// <param name="bytes">The bytes that shall be shown. This parameter can be null, but some implementations might want to require it, so read the implementations documentation of what is used/required.</param>
    /// <param name="extension">The given extension with a leading dot. This parameter can be null, but some implementations might require it, so read the implementations documentation of what is used/required.</param>
    /// <returns></returns>
    public static async Task<IBytesView?> FirstOrDefault(this IEnumerable<IBytesView> items, string mimeType, byte[]? bytes, string? extension)
    {
        foreach (var item in items)
        {
            if (await item.CanShowBytes(mimeType, bytes, extension))
            {
                return item;
            }
        }
        return null;
    }
}
