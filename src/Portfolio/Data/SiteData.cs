namespace Portfolio.Data;

public sealed record SocialLink(string Label, string Handle, string Url, string Icon);

public sealed record TechGroup(string Title, string Caption, IReadOnlyList<string> Items);

public sealed record TimelineEntry(string Period, string Title, string Place, string Body, IReadOnlyList<string> Tags);

public sealed record Service(string Icon, string Title, string Body);

public sealed record Stat(string Value, string Label);

/// <summary>
/// Single source of truth for every piece of copy on the site.
/// Edit here and the whole portfolio follows.
/// </summary>
public static class SiteData
{
    public const string Name = "David Isea";
    public const string Handle = "AlucardSanin";
    public const string Email = "davidisea@hotmail.com";
    public const string FormEndpoint = "https://formspree.io/f/mpzbgdrg";

    public const string Role = "Full-stack .NET developer";

    public static readonly string[] RotatingRoles =
    [
        "full-stack .NET developer",
        "Blazor & C# specialist",
        "product-minded engineer",
        "one-person product team",
        "developer who actually ships"
    ];

    public const string HeroPitch =
        "I build business software that people use every day: ordering platforms, inventory systems, " +
        "invoicing flows and landing pages that move. C# on the inside, motion on the outside.";

    public const string AboutLead =
        "I started with HTML, CSS and JavaScript, spent a couple of years shipping React SPAs, " +
        "and then fell hard for C#. Today I live in the .NET ecosystem: Blazor on the front, " +
        "Entity Framework Core and SQL Server on the back, and .NET MAUI when the same product " +
        "also has to fit in a pocket.";

    public const string AboutBody =
        "What I like most is the unglamorous part of software: the yard worker who needs to find an engine " +
        "in thirty seconds, the restaurant that cannot lose an order at peak hour, the agency that needs its " +
        "brand to feel alive in the first three seconds. I design the data model, write the services, build " +
        "the UI, and stay until it runs in production behind nginx on a real server.";

    public static readonly SocialLink[] Socials =
    [
        new("GitHub", "@AlucardSanin", "https://github.com/AlucardSanin", "github"),
        new("LinkedIn", "in/davidisea", "https://www.linkedin.com/in/davidisea/", "linkedin"),
        new("X", "@cadivisea", "https://twitter.com/cadivisea", "x"),
        new("Email", Email, $"mailto:{Email}", "mail")
    ];

    public static readonly Stat[] Stats =
    [
        new("4+", "years building for the web"),
        new("3", "products live in production"),
        new("40+", "public repositories"),
        new("1", "codebase → web, Android & iOS")
    ];

    /// <summary>Phrases that drift across the hero background.</summary>
    public static readonly string[] AirPhrases =
    [
        "ship it",
        "<Blazor />",
        "async all the way",
        "dotnet watch",
        "SELECT * FROM ideas",
        "one codebase, every screen",
        "null checks save lives",
        "state is a lie",
        "make it move",
        "await Task.Ship()",
        "0 commissions",
        "VIN decoded ✓",
        "measure, then optimize",
        "it runs in production",
        "coffee.Refill()",
        "C#",
        "EF Core",
        "SignalR",
        "MAUI",
        "SQL Server"
    ];

    public static readonly TechGroup[] Stack =
    [
        new("Languages", "What I think in",
            ["C#", "JavaScript", "SQL / T-SQL", "HTML5", "CSS3", "Ruby"]),

        new(".NET", "Where I spend my days",
            [".NET 10", "Blazor Server", "Blazor WebAssembly", "Blazor Hybrid", "ASP.NET Core", ".NET MAUI", "SignalR", "Entity Framework Core"]),

        new("Front-end", "Making it feel good",
            ["React", "Redux", "Tailwind CSS", "Bootstrap", "Syncfusion Blazor", "Leaflet", "CSS animation", "Responsive design"]),

        new("Data", "Where the truth lives",
            ["SQL Server", "PostgreSQL", "EF Core migrations", "Schema design", "Audit trails", "Versioned SQL scripts"]),

        new("Integrations", "Plugging into the real world",
            ["Stripe", "DocuSeal e-signature", "MailKit / SMTP", "QuestPDF", "Google reCAPTCHA", "Geolocation & maps", "VIN decoding APIs"]),

        new("Ship & run", "Getting it out the door",
            ["Git & GitHub", "GitHub Actions", "Visual Studio", "nginx on Ubuntu", "Netlify", "Kestrel", "Linters & code review"])
    ];

    public static readonly TimelineEntry[] Timeline =
    [
        new("2022", "Remote full-stack program", "Microverse",
            "Learned the craft the hard way: daily pair programming with developers in other time zones, " +
            "code reviews on everything, and a curriculum that went from raw HTML/CSS to Ruby on Rails and React.",
            ["Ruby on Rails", "RSpec", "JavaScript", "Pair programming"]),

        new("2022 – 2023", "The JavaScript years", "Freelance & personal products",
            "Shipped single-page apps consuming public APIs — rockets and missions from SpaceX, a bookshelf, " +
            "recipe catalogs, presale pages — learning state management, component design and CSS the useful way.",
            ["React", "Redux", "Tailwind CSS", "REST APIs"]),

        new("2024 – 2025", "The turn to C#", "Self-directed",
            "Moved from the JavaScript ecosystem into .NET on purpose: strong typing, Entity Framework Core, " +
            "relational modelling, and Blazor as a way to write the whole product in one language.",
            ["C#", "EF Core", "SQL Server", "Clean layering"]),

        new("2026", "Shipping products in production", "MyDinner · RSY Yard · Arrieta Agency",
            "Three live products in one year: a Swiss gastro ordering platform, a yard inventory and invoicing " +
            "system with a mobile twin, and a motion-driven brand landing. Design, data model, code and deploy.",
            ["Blazor", ".NET MAUI", "QuestPDF", "Stripe", "nginx"])
    ];

    public static readonly Service[] Services =
    [
        new("layers", "Business software that fits the business",
            "Inventory, CRM, invoicing, roles and audit trails. I start from how your team actually works, " +
            "model the data around it, and build the screens last."),

        new("bolt", "Real-time web apps in Blazor",
            "Interactive Blazor Server over SignalR or standalone WebAssembly — grids, dashboards, live state " +
            "and forms that do not fight the user."),

        new("phone", "One codebase, web and mobile",
            "Blazor Hybrid with .NET MAUI means the same Razor components run on the browser, on Android " +
            "and on iOS. One team, one language, three platforms."),

        new("card", "Payments, PDFs and paperwork",
            "Stripe checkout, generated invoices with QuestPDF, e-signature with DocuSeal and transactional " +
            "email with MailKit — the boring parts that make software billable."),

        new("sparkle", "Landings that make people stop scrolling",
            "Hand-written CSS motion, scroll choreography and typography with personality. No template smell."),

        new("server", "Deployed, not just delivered",
            "SQL Server schema scripts, environment configuration, nginx on Ubuntu, static hosting on Netlify. " +
            "I hand over something that is already running.")
    ];

    public static readonly Project[] Projects =
    [
        new()
        {
            Slug = "mydinner",
            Name = "MyDinner",
            Tagline = "Order-anywhere platform for Swiss restaurants",
            Role = "Full-stack .NET developer",
            Period = "Ongoing",
            Kind = ProjectKind.Platform,
            Accent = "#ff7a45",
            Featured = true,
            Shot = "img/shots/mydinner.webp",
            Summary =
                "A gastronomy platform that gives every restaurant its own ordering portal: guests scan a QR code " +
                "at the table, order take-away or delivery, and the kitchen sees it instantly — integrated with the " +
                "point-of-sale system, with no per-order commission for the restaurant.",
            Stack = ["C#", "Blazor Server", "SignalR", "Syncfusion Blazor", "Stripe", "Leaflet", "SQL Server", "Kestrel"],
            Metrics = ["240+ ordering languages", "QR · take-away · delivery", "0% commission model"],
            Highlights =
            [
                "Interactive Blazor Server UI kept in sync over SignalR, so the dining room and the kitchen never drift apart.",
                "Stripe payment flow wired into the ordering journey.",
                "Leaflet maps plus browser geolocation for delivery areas and address resolution.",
                "Service filtering, live translation and in-browser PDF/document viewing built on the Syncfusion Blazor suite."
            ],
            CaseStudy =
            [
                new("The problem",
                    "Delivery marketplaces charge restaurants a cut of every single order. MyDinner flips the model: " +
                    "a flat subscription and a portal the restaurant actually owns, working next to — or completely " +
                    "independent from — their POS."),
                new("What I work on",
                    "Feature work across the client-facing portal: the ordering flow, service and category filtering, " +
                    "map and geolocation features, payment steps, document generation and the multi-language layer " +
                    "that lets a guest order in their own language."),
                new("Why Blazor Server",
                    "Ordering is a live, stateful conversation between guest, kitchen and till. Blazor Server over " +
                    "SignalR keeps a single source of truth on the server and pushes updates to every connected screen " +
                    "without shipping a separate API and front-end framework.")
            ],
            Links = [new("Visit site", "https://mydinner.ch/", "external")]
        },

        new()
        {
            Slug = "rsy-yard",
            Name = "RSY Yard Inventory",
            Tagline = "Inventory, acquisition and invoicing CRM for a salvage yard",
            Role = "Architect & full-stack developer",
            Period = "2026",
            Kind = ProjectKind.Product,
            Accent = "#22d3ee",
            Featured = true,
            Shot = "img/shots/rsy-yard.webp",
            Summary =
                "Operations software for a vehicle dismantling yard. It tracks engines, transmissions and incoming " +
                "vehicles across the physical yard, handles acquisition by VIN, produces signed purchase invoices, " +
                "and exposes a public parts search — on the web and as a native mobile app built from the same code.",
            Stack = [".NET 10", "Blazor Web App", ".NET MAUI Hybrid", "EF Core 9", "SQL Server", "QuestPDF", "DocuSeal", "MailKit", "nginx"],
            Metrics = ["Web + Android + iOS from one codebase", "14 versioned SQL migrations", "5 permission roles"],
            Highlights =
            [
                "Physical yard modelled as Zone → Row → Pallet, with capacity rules the software enforces (one engine and up to two transmissions per pallet).",
                "Vehicle acquisition by VIN with decoding and auto-fill, purchase price, source dealer, pickup driver and photo evidence.",
                "Purchase invoices generated as PDFs with QuestPDF, sent for e-signature through DocuSeal and delivered by MailKit.",
                "Every movement is written to an audit trail: sold or relocated, by whom, and when.",
                "Role-based access — Viewer, Inventory Editor, Zone Manager, Vehicle Acquirer and System Admin.",
                "A public, no-login parts search so customers can check availability themselves."
            ],
            CaseStudy =
            [
                new("The problem",
                    "A yard full of engines, transmissions and half-dismantled vehicles is inventory that only exists " +
                    "in someone's head. Finding a part meant walking rows. Buying a car meant paper. Nothing was auditable."),
                new("The model",
                    "Three layers — Data, Web and Mobile — over a SQL Server schema that is versioned as plain SSMS " +
                    "scripts rather than magic migrations, so the yard's own IT can read exactly what changed. " +
                    "Business rules (pallet capacity, movement legality, zone deletion) live in the data layer, " +
                    "not scattered through the UI."),
                new("Web and mobile without a rewrite",
                    "The web app is a Blazor Web App running Interactive Server; the mobile app is .NET MAUI Blazor " +
                    "Hybrid. Same Razor components, same services, same validation — one place to fix a bug."),
                new("Paperwork as a feature",
                    "Buying a vehicle ends in a signed invoice. The app renders it from a configurable template, " +
                    "routes it through DocuSeal for signatures, emails the counterpart and stores the result " +
                    "against the vehicle record.")
            ],
            Links =
            [
                new("Visit site", "https://www.inventory-rsy.online/", "external"),
                new("Source", "https://github.com/AlucardSanin/RSYInventoryManagenemt", "github")
            ]
        },

        new()
        {
            Slug = "arrieta-agency",
            Name = "Arrieta Agency",
            Tagline = "A brand landing with hand-built motion",
            Role = "Blazor & front-end developer",
            Period = "2026",
            Kind = ProjectKind.Landing,
            Accent = "#ffd23f",
            Featured = true,
            Shot = "img/shots/arrieta-agency.webp",
            Summary =
                "A one-page brand experience for a marketing studio working with clients in Venezuela, Colombia, " +
                "the United States and Switzerland. Built as a component-driven Blazor app with a custom animation " +
                "layer instead of an off-the-shelf library.",
            Stack = ["C#", "ASP.NET Core Blazor", "Custom CSS animation", "SVG", "Responsive layout"],
            Metrics = ["8 composed sections", "0 animation libraries", "Custom typography"],
            Highlights =
            [
                "Every section is its own Razor component — hero, manifesto, services, process, brands, numbers, footer.",
                "A dedicated animation stylesheet drives scroll reveals, floating shapes and hover choreography.",
                "Expanding gallery of campaign results that opens on hover and stays keyboard reachable.",
                "Bespoke display typeface and an illustrated SVG system for the brand's playful voice."
            ],
            CaseStudy =
            [
                new("The brief",
                    "Two siblings running a marketing agency needed a site that felt like them: warm, playful and " +
                    "clearly not a template. It had to load fast and read well on a phone, because that is where " +
                    "their audience finds them."),
                new("The approach",
                    "Blazor components per section so copy can change without touching layout, plus a single " +
                    "animation stylesheet so motion stays consistent across the page instead of being invented " +
                    "section by section.")
            ],
            Links =
            [
                new("Visit site", "https://arrietagency.com/", "external"),
                new("Source", "https://github.com/AlucardSanin/GinsaASPNETBlazorWebApp", "github")
            ]
        },

        new()
        {
            Slug = "mcboverso",
            Name = "McboVerso",
            Tagline = "A playable 3D slice of Maracaibo",
            Role = "Creator",
            Period = "2026",
            Kind = ProjectKind.Experiment,
            Accent = "#7c5cff",
            Summary = "A 3D, walkable version of my city on the web — a playground for spatial UI and real-time rendering.",
            Stack = ["3D web", "Real-time rendering", "Game loop"],
            Links = [new("Source", "https://github.com/AlucardSanin/McboVerso", "github")]
        },

        new()
        {
            Slug = "spacehub",
            Name = "SpaceHub",
            Tagline = "Book rockets and missions from the SpaceX API",
            Role = "Front-end developer",
            Period = "2023",
            Kind = ProjectKind.Product,
            Accent = "#38bdf8",
            Summary = "A React and Redux app that pulls live data from the SpaceX API and lets you reserve rockets and join missions.",
            Stack = ["React", "Redux", "Tailwind CSS", "REST API"],
            Links = [new("Source", "https://github.com/AlucardSanin/SpaceHub", "github")]
        },

        new()
        {
            Slug = "bookstore",
            Name = "Bookstore",
            Tagline = "Your own web bookshelf",
            Role = "Front-end developer",
            Period = "2025",
            Kind = ProjectKind.Product,
            Accent = "#34d399",
            Summary = "Track what you read and what you are still pretending to read. React for the UI, Redux for the state.",
            Stack = ["React", "Redux", "JavaScript"],
            Links = [new("Source", "https://github.com/AlucardSanin/books_store", "github")]
        },

        new()
        {
            Slug = "mealsdb",
            Name = "MealsDB",
            Tagline = "API-driven recipe catalog",
            Role = "Front-end developer",
            Period = "2023",
            Kind = ProjectKind.Product,
            Accent = "#f472b6",
            Summary = "A small web app that fetches and filters meals from a public API — my first serious lesson in async UI states.",
            Stack = ["JavaScript", "HTML", "CSS", "REST API"],
            Links = [new("Source", "https://github.com/AlucardSanin/MealsDB", "github")]
        },

        new()
        {
            Slug = "school-library",
            Name = "School Library",
            Tagline = "Object-oriented Ruby, done properly",
            Role = "Back-end developer",
            Period = "2023",
            Kind = ProjectKind.Experiment,
            Accent = "#fb7185",
            Summary = "A librarian's tool built to practise OOP: students, teachers, books and rentals, with a clean class hierarchy.",
            Stack = ["Ruby", "OOP", "RSpec"],
            Links = [new("Source", "https://github.com/AlucardSanin/School-Library", "github")]
        },

        new()
        {
            Slug = "vet-clinic",
            Name = "Vet Clinic Database",
            Tagline = "Relational modelling from scratch",
            Role = "Database developer",
            Period = "2023",
            Kind = ProjectKind.Experiment,
            Accent = "#a3e635",
            Summary = "A PostgreSQL schema for a veterinary clinic: entities, relationships, constraints and the queries to prove it works.",
            Stack = ["PostgreSQL", "PL/pgSQL", "Schema design"],
            Links = [new("Source", "https://github.com/AlucardSanin/vet-clinic", "github")]
        }
    ];

    public static Project? FindProject(string slug) =>
        Projects.FirstOrDefault(p => string.Equals(p.Slug, slug, StringComparison.OrdinalIgnoreCase));

    public static IEnumerable<Project> Featured => Projects.Where(p => p.Featured);

    public static IEnumerable<Project> More => Projects.Where(p => !p.Featured);
}
