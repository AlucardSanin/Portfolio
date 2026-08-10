using Microsoft.JSInterop;

namespace Portfolio.Services;

public sealed class ThemeService(IJSRuntime js)
{
    public const string Dark = "dark";
    public const string Light = "light";

    public string Current { get; private set; } = Dark;

    public event Action? Changed;

    public async Task InitializeAsync()
    {
        Current = await js.InvokeAsync<string>("portfolio.readTheme");
        Changed?.Invoke();
    }

    public async Task ToggleAsync()
    {
        Current = Current == Dark ? Light : Dark;
        await js.InvokeVoidAsync("portfolio.applyTheme", Current);
        Changed?.Invoke();
    }
}
