namespace Portfolio.Data;

public sealed record SocialLink(string Label, string Handle, string Url, string Icon);

public sealed record TechGroup(string Title, string Caption, IReadOnlyList<string> Items);

public sealed record TimelineEntry(
    string Period,
    string Title,
    string Place,
    string Body,
    IReadOnlyList<string> Tags,
    IReadOnlyList<string> Achievements);

public sealed record EducationEntry(string Period, string Title, string Place, IReadOnlyList<string> Notes);

public sealed record LanguageSkill(string Name, string Level);

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
    public const string Phone = "+58 412-1702106";
    public const string Location = "Switzerland (Remote)";
    public const string FormEndpoint = "https://formspree.io/f/mpzbgdrg";

    public const string Role = ".NET Full Stack Developer";
    public const string RoleLong = ".NET Full Stack Developer · Blazor · MAUI · SQL · React";

    public static readonly string[] RotatingRoles =
    [
        ".NET full stack developer",
        "Blazor & C# specialist",
        "core platform engineer",
        "one-person product team",
        "developer who actually ships"
    ];

    public const string HeroPitch =
        "I design, build and maintain production SaaS for the Swiss hospitality industry. Real-time order " +
        "management, Stripe payments, multi-tenant SQL Server and a mobile app — all of it end to end, " +
        "all of it live.";

    public const string Summary =
        "Passionate full stack .NET developer with hands-on experience building production-grade enterprise " +
        "web and mobile applications for the Swiss hospitality industry. I currently architect and develop " +
        "MyDinner.ch — a complete restaurant management SaaS platform — including real-time order management, " +
        "Stripe payment integration, multi-language support and a complex Blazor Server front-end.";

    public const string AboutLead =
        "I am the sole developer behind a SaaS platform that real restaurants depend on every night.";

    public const string AboutBody =
        "Proven ability to independently design scalable systems, optimise database performance and deliver " +
        "features end to end — from the SQL schema to the button the waiter presses. I studied software " +
        "engineering at URBE, sharpened the fundamentals through 1,300+ hours at Microverse, and have been " +
        "shipping .NET in production since November 2022. I communicate clearly across distributed teams and " +
        "I am comfortable being the person who owns the whole stack.";

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
        new("70%", "less database load after query tuning"),
        new("24+", "granular permission flags shipped"),
        new("1", "codebase → web, Android & iOS")
    ];

    public static readonly LanguageSkill[] Languages =
    [
        new("Spanish", "Native"),
        new("English", "Professional"),
        new("German", "Basic")
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
        "multi-tenant by design",
        "state is a lie",
        "make it move",
        "await Task.Ship()",
        "PaymentIntent ✓",
        "SignalR",
        "measure, then optimize",
        "it runs in production",
        "coffee.Refill()",
        "C#",
        "EF Core",
        ".Select() > .Include()",
        "MAUI",
        "SQL Server"
    ];

    public static readonly TechGroup[] Stack =
    [
        new("Back-end", "Where the logic lives",
            ["C#", ".NET 9 / .NET 10", "ASP.NET Core", "Blazor Server", "Entity Framework Core", "REST APIs", "SignalR"]),

        new("Front-end", "What the user touches",
            ["Blazor", "React", "JavaScript", "HTML5", "CSS3", "Syncfusion UI Components", "Tailwind CSS"]),

        new("Mobile", "The same product, in a pocket",
            [".NET MAUI", "Blazor Hybrid", "iOS", "Android"]),

        new("Database", "Where the truth lives",
            ["MS SQL Server", "T-SQL", "SSMS", "EF Core migrations", "Query optimisation", "Multi-tenant design", "PostgreSQL"]),

        new("Payments & documents", "The parts that make software billable",
            ["Stripe PaymentIntent", "Stripe SetupIntent", "Stripe Connect accounts", "Webhooks", "PDF receipts", "Excel export"]),

        new("DevOps & tools", "Getting it out the door",
            ["Git & GitHub", "Visual Studio 2022", "IIS", "Azure (basic)", "nginx", "Agile / Scrum"])
    ];

    public static readonly TimelineEntry[] Timeline =
    [
        new("Nov 2022 – Present",
            ".NET Full Stack Developer — Core Platform Engineer",
            "Otamot GmbH / MyDinner.ch · Technolog Schweiz — Switzerland (Remote)",
            "Sole developer responsible for designing, building and maintaining MyDinner.ch, a full-featured " +
            "SaaS platform for Swiss restaurant management. The platform serves real restaurants in production " +
            "with thousands of orders processed.",
            ["Blazor Server", "SignalR", "EF Core", "SQL Server", ".NET MAUI", "Stripe"],
            [
                "Architected a real-time order management system with Blazor Server and SignalR so kitchen staff, service teams and managers collaborate live across devices.",
                "Engineered a multi-tenant database architecture in MS SQL Server with Entity Framework Core, supporting multiple restaurants under one platform with isolated data.",
                "Implemented full Stripe payments: PaymentIntent, SetupIntent, Connect accounts for restaurant sub-accounts, and automated PDF receipts.",
                "Designed a role-based permission system with granular access per user type — Admin, Service Staff, Kitchen, Driver, Printer — covering 24+ individual permission flags.",
                "Developed a .NET MAUI mobile app for iOS and Android, synchronised in real time with the web platform through REST APIs.",
                "Built a reporting module with Excel/PDF export, date-range filtering, sales statistics by table and best-selling product analytics.",
                "Cut server load by over 70% in high-volume periods by replacing full entity graph loads with targeted EF Core projections."
            ]),

        new("Apr 2022 – Nov 2022",
            "Full Stack Web Development Student & Peer Mentor",
            "Microverse — Remote",
            "1,300+ hours of intensive full stack training with daily pair programming across time zones, " +
            "and mentoring for developers coming up behind me.",
            ["JavaScript", "React", "Redux", ".NET", "Git workflow"],
            [
                "Completed 1,300+ hours of intensive full stack training covering JavaScript, React, Redux and .NET.",
                "Mentored junior developers in pair-programming sessions, code review and Git/GitHub best practices.",
                "Delivered multiple full stack capstone projects, independently and with international teammates."
            ]),

        new("Jan 2019 – Dec 2019",
            "Hardware & Software Technician",
            "Self-employed — Maracaibo, Venezuela",
            "Where I learned that a system is only as good as the person who has to use it at 8am on a Monday.",
            ["Troubleshooting", "Deployment", "Client support"],
            [
                "Diagnosed and resolved hardware and software issues, improving system performance and reducing customer turnaround time.",
                "Deployed new hardware configurations and software solutions tailored to client requirements."
            ])
    ];

    public static readonly EducationEntry[] Education =
    [
        new("2012 – 2022", "Software Engineering", "Universidad Rafael Belloso Chacín (URBE) · Maracaibo, Venezuela",
            [
                "Focused on software architecture, database design and systems engineering.",
                "Led a capstone project introducing a modernised approach to software project design, replacing legacy methodologies."
            ]),

        new("2022", "Remote Full Stack Web Development Program", "Microverse · Remote",
            [
                "Mastered algorithms, data structures and full stack development through 1,300+ hours of structured training."
            ])
    ];

    public static readonly Service[] Services =
    [
        new("layers", "Multi-tenant SaaS, built properly",
            "One platform, many customers, isolated data. I have designed and shipped the schema, the tenancy " +
            "model and the permission system that keeps them apart."),

        new("bolt", "Real-time apps in Blazor",
            "Blazor Server over SignalR for live dashboards, order boards and anything where two people need " +
            "to see the same truth at the same second."),

        new("phone", "One codebase, web and mobile",
            "Blazor Hybrid with .NET MAUI puts the same Razor components in the browser, on Android and on iOS. " +
            "One team, one language, three platforms."),

        new("card", "Payments, PDFs and paperwork",
            "Stripe PaymentIntent, SetupIntent and Connect sub-accounts, webhooks, automated receipts, " +
            "invoice generation and e-signature. The boring parts, done right."),

        new("server", "Databases that stay fast",
            "T-SQL, EF Core migrations and query optimisation. On MyDinner, targeted projections cut server " +
            "load by more than 70% during peak service."),

        new("sparkle", "Interfaces that make people stop scrolling",
            "Hand-written CSS motion, scroll choreography and typography with personality. No template smell.")
    ];

    public static readonly Project[] Projects =
    [
        new()
        {
            Slug = "mydinner",
            Name = "MyDinner.ch",
            Tagline = "Restaurant management SaaS for Switzerland",
            Role = "Core Platform Engineer · sole developer",
            Period = "Nov 2022 – Present",
            Kind = ProjectKind.Platform,
            Accent = "#ff7a45",
            Featured = true,
            Shot = "img/shots/mydinner.webp",
            Summary =
                "A complete restaurant management platform: guests order from the table by QR code, take away " +
                "or get delivery; the kitchen, the waiters and the manager see every order live; payments run " +
                "through Stripe; and the whole thing is multi-tenant, so each restaurant gets its own isolated " +
                "world under one platform. It serves real restaurants in production, with thousands of orders " +
                "processed and no per-order commission.",
            Stack = ["C#", "Blazor Server", "SignalR", "EF Core", "MS SQL Server", ".NET MAUI", "Stripe", "Syncfusion", "REST APIs"],
            Metrics = ["Thousands of orders processed", "70% less server load at peak", "24+ permission flags", "Web + iOS + Android"],
            Highlights =
            [
                "Real-time order management over Blazor Server and SignalR: kitchen staff, service teams and managers collaborate live across devices.",
                "Multi-tenant architecture in MS SQL Server with Entity Framework Core — many restaurants, one platform, isolated data.",
                "Full Stripe integration: PaymentIntent, SetupIntent, Connect accounts for restaurant sub-accounts, webhooks and automated PDF receipts.",
                "Role-based permissions with granular control per user type — Admin, Service Staff, Kitchen, Driver, Printer — across 24+ individual flags.",
                "A .NET MAUI mobile app for iOS and Android, synchronised in real time with the web platform through REST APIs.",
                "Reporting module with Excel and PDF export, date-range filtering, sales statistics by table and best-selling product analytics.",
                "Multi-language ordering, geolocation and map-based delivery areas so a guest can order in their own language."
            ],
            CaseStudy =
            [
                new("The problem",
                    "Delivery marketplaces take a cut of every order and own the customer relationship. MyDinner " +
                    "flips that: a subscription, a portal the restaurant actually owns, and a system that works " +
                    "next to the point-of-sale — or completely without it."),
                new("My role",
                    "Sole developer. I designed the data model, wrote the services, built the front-end, shipped " +
                    "the mobile app and keep it running in production. Every architectural decision on the " +
                    "platform is one I had to defend to myself first."),
                new("Why Blazor Server",
                    "An order is a live conversation between guest, waiter, kitchen and till. Blazor Server over " +
                    "SignalR keeps one source of truth on the server and pushes it to every connected screen, " +
                    "without maintaining a separate API and a separate front-end framework."),
                new("Making it fast",
                    "Peak service is the only performance test that matters. The biggest win came from replacing " +
                    "full entity-graph loads with targeted EF Core projections through .Select(), which dropped " +
                    "server load by more than 70% during high-volume periods."),
                new("Getting paid",
                    "Stripe Connect gives each restaurant its own sub-account, so money moves directly to them. " +
                    "PaymentIntent and SetupIntent cover one-off and stored-card flows, webhooks reconcile the " +
                    "state, and receipts are generated as PDFs automatically.")
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
                "and exposes a public parts search — on the web and as a mobile app built from the same code.",
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
                    "Three layers — Data, Web and Mobile — over a SQL Server schema versioned as plain SSMS scripts " +
                    "rather than opaque migrations, so the yard's own IT can read exactly what changed. Business rules " +
                    "(pallet capacity, movement legality, zone deletion) live in the data layer, not scattered through the UI."),
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
