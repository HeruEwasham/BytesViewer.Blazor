using System.Threading.Tasks;
using Blazored.Video;
using YngveHestem.BytesViewer.Blazor.Core;

namespace YngveHestem.BytesViewer.Blazor.MediaPlayer;

public class MediaPlayerView : IBytesView
{
    public async Task<bool> CanShowBytes(string mimeType, byte[]? bytes = null, string? extension = null)
    {
         return await new BlazoredVideo().CanPlayMediaType(mimeType);
    }

    public Task<Dictionary<string, object>> GetComponentParameters(string mimeType, byte[] bytes, string? extension = null)
    {
        return Task.FromResult(new Dictionary<string, object>
        {
            { "Src", $"data:{mimeType};base64,{Convert.ToBase64String(bytes)}" }
        });
    }

    public Task<Type> GetComponentType(string mimeType, byte[]? bytes = null, string? extension = null)
    {
        return Task.FromResult(typeof(BlazoredVideo));
    }
}
