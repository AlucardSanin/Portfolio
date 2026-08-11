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
- **A printable résumé** at `/resume`, generated from the same `SiteData.cs` as the rest of the
  site, with print styles so "Save as PDF" produces a clean document.
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

## Hosting it anywhere

The output is plain static files. Upload the **contents** of `publish/wwwroot` to the web root of
whatever host you use. Two things must be right on any server:

1. **MIME types** — `.wasm` must be served as `application/wasm`.
2. **SPA fallback** — any URL that does not match a file has to return `index.html`, otherwise
   `/work/rsy-yard` and `/resume` will 404 on a hard refresh.

### IIS

`web.config` ships inside `publish/wwwroot` and already handles both. Just copy the folder into
the site directory. The URL Rewrite module must be installed.

### nginx

```nginx
server {
    root /var/www/portfolio;
    index index.html;

    location / {
        try_files $uri $uri/ /index.html;
    }

    location /_framework/ {
        add_header Cache-Control "public, max-age=31536000, immutable";
    }

    types { application/wasm wasm; }
    gzip on;
    gzip_types text/css text/javascript application/json application/wasm application/octet-stream;
}
```

### Apache

```apache
<Directory "/var/www/portfolio">
    AddType application/wasm .wasm
    FallbackResource /index.html
</Directory>
```

### Netlify

`netlify.toml` is already configured (`./build.sh`, publish `publish/wwwroot`, SPA fallback and
long-lived caching for `_framework`). Netlify images have no .NET SDK, so `build.sh` installs it
on demand. Delete the file if you host elsewhere.

### A note on size

The first visit downloads the .NET runtime — roughly 2.5 MB over Brotli, cached forever after
that. Make sure your host serves the pre-compressed `.br` / `.gz` files, or enables compression
itself. The boot screen covers that first load.

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

## One Razor gotcha worth knowing

On .NET SDK 10.0.302 the Razor compiler mis-parses two things when they sit **directly inside a
code block** (`@if`, `@foreach`, …):

- `<PageTitle>` — keep it outside the branches and bind a field instead.
- a component whose own root element is `<article>`, `<section>`, `<header>`, `<footer>` or
  `<figure>` — give the component a `<div>` root, or wrap the tag in a plain element.

Both patterns survive incremental builds and only fail on a clean one, so **always test with a
fresh `obj/`** before trusting a green build:

```bash
rm -rf src/Portfolio/obj src/Portfolio/bin
dotnet build DavidIseaPortfolio.slnx -c Release /warnaserror
```

## Legacy site

The original 2022 HTML/CSS/JS portfolio is preserved under [`legacy/`](./legacy) for reference.

## License

MIT
