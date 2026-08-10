# David Isea — Portfolio

A dynamic developer portfolio built with **Blazor WebAssembly on .NET 10**. It ships as a fully
static site, so it can be hosted anywhere: Netlify, GitHub Pages, Azure Static Web Apps or an
nginx folder.

Live projects featured here: [mydinner.ch](https://mydinner.ch/),
[inventory-rsy.online](https://www.inventory-rsy.online/) and
[arrietagency.com](https://arrietagency.com/).

## What is in it

- **Single-page experience** with a fixed navbar that tracks the section you are reading,
  a mobile menu, a scroll-progress bar and a footer.
- **Case-study routes** (`/work/{slug}`) rendered by the Blazor router from the same data source.
- **Motion**: floating phrases in the hero, aurora blobs, a typewriter role, scroll reveals,
  animated counters, pointer-following glow and card tilt — all of it disabled automatically
  when the visitor prefers reduced motion.
- **Dark and light themes**, persisted in `localStorage`.
- **Contact form** posted to Formspree as JSON, with inline validation and success state.

## Project layout

```
src/Portfolio/
├── Data/                 # SiteData.cs — every piece of copy lives here
│   ├── Project.cs
│   └── SiteData.cs
├── Components/
│   ├── Sections/         # Hero, Work, About, Stack, Journey, Services, Contact
│   ├── NavBar.razor
│   ├── Footer.razor
│   ├── FloatingPhrases.razor
│   ├── SectionHeading.razor
│   └── Icon.razor        # inline SVG icon set
├── Layout/MainLayout.razor
├── Pages/                # Home, ProjectDetail, NotFound
├── Services/             # ThemeService, InteractionService (JS interop)
└── wwwroot/
    ├── css/app.css
    ├── js/site.js        # observers, tilt, pointer, theme, clipboard
    └── img/shots/        # screenshots of the live products
```

`Data/SiteData.cs` is the single source of truth. Change a project, a stat or a phrase there and
the whole site follows — no markup edits required.

## Running it locally

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
dotnet restore DavidIseaPortfolio.slnx
dotnet run --project src/Portfolio/Portfolio.csproj
```

Then open the URL printed in the console (`http://localhost:5xxx`).

## Building for production

```bash
./build.sh          # installs the SDK if missing, publishes to ./publish
```

The deployable static site is `publish/wwwroot`.

## Deploying to Netlify

`netlify.toml` is already configured:

- **Build command:** `./build.sh`
- **Publish directory:** `publish/wwwroot`
- SPA fallback (`/* → /index.html`) so `/work/rsy-yard` resolves on a hard refresh
- Long-lived caching for `_framework` and `.wasm` assets

Netlify images do not ship a .NET SDK, so `build.sh` installs it on demand before publishing.

## Adding a project

Append a new `Project` to `SiteData.Projects`:

```csharp
new()
{
    Slug = "my-project",
    Name = "My Project",
    Tagline = "One line that sells it",
    Role = "Full-stack developer",
    Period = "2026",
    Kind = ProjectKind.Product,
    Accent = "#22d3ee",
    Featured = true,                       // featured items get a case-study route
    Shot = "img/shots/my-project.webp",
    Summary = "What it does and who uses it.",
    Stack = ["C#", "Blazor", "SQL Server"],
    Metrics = ["Something measurable"],
    Highlights = ["A capability worth calling out"],
    CaseStudy = [new("The problem", "…"), new("The approach", "…")],
    Links = [new("Visit site", "https://example.com", "external")]
}
```

## Legacy site

The original 2022 HTML/CSS/JS portfolio is preserved under [`legacy/`](./legacy) for reference.

## License

MIT
