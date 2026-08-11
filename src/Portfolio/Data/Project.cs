namespace Portfolio.Data;

public enum ProjectKind
{
    Platform,
    Product,
    Landing,
    Experiment
}

public sealed record ProjectLink(string Label, string Url, string Icon);

public sealed record ProjectHighlight(string Title, string Detail);

public sealed record Project
{
    public required string Slug { get; init; }
    public required string Name { get; init; }
    public required string Tagline { get; init; }
    public required string Role { get; init; }
    public required string Period { get; init; }
    public required ProjectKind Kind { get; init; }
    public required string Accent { get; init; }
    public required string Summary { get; init; }
    public required IReadOnlyList<string> Stack { get; init; }
    public IReadOnlyList<string> Highlights { get; init; } = [];
    public IReadOnlyList<ProjectHighlight> CaseStudy { get; init; } = [];
    public IReadOnlyList<ProjectLink> Links { get; init; } = [];
    public IReadOnlyList<string> Metrics { get; init; } = [];
    public bool Featured { get; init; }

    /// <summary>Screenshot of the live product, relative to wwwroot.</summary>
    public string? Shot { get; init; }

    public string KindLabel => Kind switch
    {
        ProjectKind.Platform => "Platform",
        ProjectKind.Product => "Product",
        ProjectKind.Landing => "Landing",
        _ => "Experiment"
    };
}
