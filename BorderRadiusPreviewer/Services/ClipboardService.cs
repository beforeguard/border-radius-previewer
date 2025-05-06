using Microsoft.JSInterop;

namespace BorderRadiusPreviewer.Services
{
    public class ClipboardService(IJSRuntime _jSRuntime)
    {
        public ValueTask WriteTextAsync(string text) => _jSRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
    }
}
