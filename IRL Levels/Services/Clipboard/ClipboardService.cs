using Microsoft.JSInterop;

namespace IRL_Levels.Services.Clipboard;

public interface IClipboardService
{
    Task CopyToClipboard(string text);
}

public class ClipboardService(IJSRuntime _jsInteropt) : IClipboardService
{
    public async Task CopyToClipboard(string text)
    {
        await _jsInteropt.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}
