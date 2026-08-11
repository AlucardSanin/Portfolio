using Microsoft.JSInterop;

namespace Portfolio.Services;

/// <summary>
/// Thin wrapper over the browser behaviours in <c>wwwroot/js/site.js</c>.
/// </summary>
public sealed class InteractionService(IJSRuntime js)
{
    public async Task HydratePageAsync()
    {
        await js.InvokeVoidAsync("portfolio.initScrollState");
        await js.InvokeVoidAsync("portfolio.initPointer");
        await js.InvokeVoidAsync("portfolio.initReveal");
        await js.InvokeVoidAsync("portfolio.initCounters");
        await js.InvokeVoidAsync("portfolio.initTilt");
        await js.InvokeVoidAsync("portfolio.ready");
    }

    public ValueTask ObserveSectionsAsync<T>(DotNetObjectReference<T> reference) where T : class =>
        js.InvokeVoidAsync("portfolio.observeSections", reference);

    public ValueTask ScrollToAsync(string elementId) =>
        js.InvokeVoidAsync("portfolio.scrollToId", elementId);

    public ValueTask ScrollToTopAsync() =>
        js.InvokeVoidAsync("portfolio.scrollToTop");

    public ValueTask LockScrollAsync(bool locked) =>
        js.InvokeVoidAsync("portfolio.lockScroll", locked);

    public ValueTask<bool> CopyAsync(string text) =>
        js.InvokeAsync<bool>("portfolio.copyText", text);
}
