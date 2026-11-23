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
    public const string Location = "Venezuela (Remote)";
    public const string LocationDetail = "Based in Venezuela, working remotely with teams in Switzerland and LATAM";
    public const string FormEndpoint = "https://formspree.io/f/mpzbgdrg";

    public const string Role = ".NET Full Stack Developer";
    public const string RoleLong = ".NET Full Stack Developer · Blazor · MAUI · SQL · React / React Native";

    public static readonly string[] RotatingRoles =
    [
        ".NET full stack developer",
        "Blazor & C# specialist",
        "core platform engineer",
        "remote product engineer",
        "developer who actually ships"
    ];

    public const string HeroPitch =
        "I help ship production SaaS with a product team — backend, database, mobile and payments included. " +
        "On Blazor I take the lead: the interactive UI, the real-time surfaces and the screens restaurants " +
        "run every night. I work remotely from Venezuela for Otamot / technolog.ch on MyDinner.ch and Kirona ERP, " +
        "and as a freelancer I have shipped an iOS app through the App Store and Blazor sites from an empty repo.";

    public const string Summary =
        "Passionate full stack .NET developer with hands-on experience building production-grade enterprise " +
        "web and mobile applications. Remotely, I work on MyDinner.ch for a Swiss company: I contribute across " +
        "the stack — backend services, SQL Server, .NET MAUI mobile and Stripe payments — and I lead the " +
        "Blazor Server web application that restaurants and staff use every night.";

    public const string AboutLead =
        "Full stack engineer on a restaurant SaaS — team contributor across the stack, Blazor lead on the web app.";

    public const string AboutBody =
        "I work inside a product team and take part in the same processes as everyone else: backend, " +
        "database design, mobile and payments. Blazor is my main focus — the interactive UI, the " +
        "server-side state, the SignalR surfaces and the screens the waiter presses. I studied software " +
        "engineering at URBE, sharpened the fundamentals through 1,300+ hours at Microverse, and have been " +
        "shipping .NET in production since November 2022. I communicate clearly across distributed teams " +
        "and I am comfortable leading a complex web surface while still shipping with others. On the side I " +
        "freelance: Fossick, an iOS app built with Expo and React Native on top of a .NET API, went through " +
        "TestFlight and App Store Connect; and I build Blazor sites from scratch for clients who need them live fast.";

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
        new("7", "live products and sites in production"),
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
        "one codebase, every screen",
        "multi-tenant by design",
        "make it move",
        "PaymentIntent ✓",
        "SignalR",
        "measure, then optimize",
        "it runs in production",
        "C#",
        "EF Core",
        ".Select() > .Include()",
        "MAUI",
        "SQL Server",
        "expo run:ios",
        "TestFlight ✓",
        "Kirona ERP"
    ];

    public static readonly TechGroup[] Stack =
    [
        new("Back-end", "Where the logic lives",
            ["C#", ".NET 9 / .NET 10", "ASP.NET Core", "Blazor Server", "Entity Framework Core", "REST APIs", "SignalR", "Azure OpenAI", "Hangfire"]),

        new("Front-end", "What the user touches",
            ["Blazor", "Blazor WebAssembly", "React", "TypeScript", "JavaScript", "HTML5", "CSS3", "Syncfusion UI Components", "Tailwind CSS"]),

        new("Mobile", "The same product, in a pocket",
            [".NET MAUI", "Blazor Hybrid", "Expo / React Native", "iOS", "Android", "App Store Connect & TestFlight", "RevenueCat"]),

        new("Database", "Where the truth lives",
            ["MS SQL Server", "T-SQL", "SSMS", "EF Core migrations", "Query optimisation", "Multi-tenant design", "PostgreSQL"]),

        new("Payments & documents", "The parts that make software billable",
            ["Stripe PaymentIntent", "Stripe SetupIntent", "Stripe Connect accounts", "Webhooks", "PDF receipts", "Excel export"]),

        new("DevOps & tools", "Getting it out the door",
            ["Git & GitHub", "Azure DevOps", "GitHub Actions", "Visual Studio 2022", "IIS", "Azure App Service", "nginx", "Netlify / GitHub Pages", "Agile / Scrum"])
    ];

    public static readonly TimelineEntry[] Timeline =
    [
        new("2026 – Present",
            "Freelance Developer — mobile apps and websites from scratch",
            "Lume Watch LLC (Texas) · UNEFM (Venezuela) · Corvita (Miami) · RSY · Arrieta Agency — Remote",
            "Independent work alongside my main role: a thrift-value scanner app shipped to iPhone, and web " +
            "platforms and marketing sites built from an empty repository to a live domain.",
            ["Expo / React Native", "TypeScript", ".NET 10 API", "Blazor WebAssembly", "GitHub Pages", "App Store Connect"],
            [
                "Built Fossick, an iOS thrift-value scanner for Lume Watch LLC: Expo / React Native app, .NET 10 API on Azure with Azure OpenAI, and the release pipeline through TestFlight and App Store Connect.",
                "Built the Website de Fonética I for UNEFM from scratch as a backend-free Blazor WebAssembly PWA, deployed by GitHub Actions to GitHub Pages, with all content editable in Markdown and JSON.",
                "Designed and built corvitarn.com, a multi-page site for a sports recovery lounge in Miami, from desktop concepts to production, with booking, memberships and financing integrations.",
                "Delivered RSY Yard Inventory (Blazor Web App + .NET MAUI Hybrid) and the Arrieta Agency brand landing (Blazor)."
            ]),

        new("Nov 2022 – Present",
            ".NET Full Stack Developer — Core Platform Engineer",
            "Otamot GmbH / technolog.ch · MyDinner.ch & Kirona ERP — Switzerland (Remote)",
            "Full stack engineer on MyDinner.ch, a restaurant management SaaS built by a product team. " +
            "I contribute across backend, database, mobile and payments, and I lead the Blazor Server web " +
            "application. Since November 2026 I also work on Kirona ERP, the team's cloud ERP for SMEs — " +
            "web only: the Blazor product UI and the public multilingual website. Remote role for a Swiss " +
            "company; MyDinner serves restaurants in production with thousands of orders processed.",
            ["Blazor Server", "Blazor Web App", "SignalR", "EF Core", "SQL Server", ".NET MAUI", "Stripe"],
            [
                "Kirona ERP: built the public website kirona.ai from scratch as a Blazor app in five languages, redesigned the ERP dashboard and reports cockpit, and translated the core modules into ten languages.",
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

        new("phone", "Mobile apps that reach the App Store",
            "Blazor Hybrid with .NET MAUI when the web app should become the mobile app; Expo and React Native " +
            "when the phone is the product. Either way I take it through TestFlight and App Store Connect."),

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
            Tagline = "Restaurant management SaaS",
            Role = "Core Platform Engineer · Blazor lead",
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
                    "I contribute across the product — backend services, SQL Server, .NET MAUI mobile and " +
                    "Stripe payments — alongside the team. On Blazor I take the lead: the interactive UI, the " +
                    "server-side state, the SignalR real-time surfaces and the screens restaurants actually " +
                    "run. The product is a team effort; the web app is where I focus most."),
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
            Slug = "fossick",
            Name = "Fossick",
            Tagline = "Thrift value scanner for iPhone",
            Role = "Mobile & backend developer · App Store release",
            Period = "2026",
            Kind = ProjectKind.Product,
            Accent = "#c2410c",
            Featured = true,
            Shot = "img/shots/fossick.webp",
            Summary =
                "Snap a photo of any thrift find and see what the same thing actually sold for. Fossick identifies " +
                "the item, pulls real sold comps, suggests the most you should pay, and lets you log finds against " +
                "a monthly profit goal — with Digger, an AI assistant, along for the hunt. A product of Lume Watch " +
                "LLC. I built the iOS app and the API behind it, and took it through TestFlight and App Store " +
                "Connect to publication.",
            Stack = ["Expo SDK 54", "React Native", "TypeScript", "React Navigation", "Reanimated", "RevenueCat", "Sign in with Apple", ".NET 10 Web API", "EF Core · SQL Server", "Azure OpenAI", "Azure App Service", "App Store Connect · TestFlight"],
            Metrics = ["Published on iOS through App Store Connect", "28 builds shipped via TestFlight", "English & Spanish", "3 free scans · Pro monthly & lifetime"],
            Highlights =
            [
                "Camera scan → AI identification → sold-comp price range with a 'pay at most' figure, each scan linked to the listings behind it.",
                "Digger, an AI assistant you can ask about an item, with a native camera / photo-library picker that feeds the conversation.",
                "Monthly profit goal, find log, quests and an activity feed so the hunt has a scoreboard.",
                "Nearby thrift stores and 'hunting grounds' on a map, with category whitelists and routing fallbacks.",
                "Sign in with Apple and social login; subscriptions through RevenueCat — 3 free scans, Pro Monthly and Pro Lifetime.",
                "Onboarding with a hand-built sprite-atlas mascot at 24 fps, reduced-motion fallbacks and compact layouts for small phones.",
                "No ads and no cross-app tracking; privacy manifest and permission copy written for App Review."
            ],
            CaseStudy =
            [
                new("The problem",
                    "Resellers walk thrift racks guessing. Fossick turns a photo into an answer: what is it, what did " +
                    "it sell for recently, and what is the most you should pay for it right now."),
                new("My role",
                    "The whole product from the data model to the store listing: the Expo / React Native app, the " +
                    "ASP.NET Core API, the SQL Server schema and the release pipeline. I also wrote the identification " +
                    "rules — a watch needs brand and model with enough confidence before pricing is allowed."),
                new("Getting it onto iPhones",
                    "Native workflow, not Expo Go: prebuild, Xcode archives, signed exports and uploads to App Store " +
                    "Connect. Twenty-eight TestFlight builds, each one a round of feedback, before the version " +
                    "that went to review. Permission strings, privacy manifest and Sign in with Apple were all " +
                    "part of passing it."),
                new("The backend",
                    "A .NET 10 Web API on Azure App Service with EF Core over SQL Server, JWT auth, Azure Blob " +
                    "Storage for photos and Azure OpenAI for identification and the Digger chat, including a " +
                    "tool-calling loop that had to survive its second turn."),
                new("Making it feel native",
                    "React Navigation with native stack transitions, Reanimated for the mascot and reveals, haptics " +
                    "where they earn it, and Reduce Motion respected everywhere. Every flow was walked on the " +
                    "simulator with scripted taps before it shipped.")
            ],
            Links = [new("Visit site", "https://fossick.lumewatch.us/", "external")]
        },

        new()
        {
            Slug = "kirona",
            Name = "Kirona ERP",
            Tagline = "Cloud ERP for SMEs with an AI assistant",
            Role = "Web developer · Blazor (Otamot / technolog.ch)",
            Period = "Nov 2026 – Present",
            Kind = ProjectKind.Platform,
            Accent = "#6366f1",
            Featured = true,
            Shot = "img/shots/kirona.webp",
            Summary =
                "One system from the first quote to the paid invoice: sales, production, inventory, logistics and " +
                "accounting for small and medium businesses, with an AI assistant that answers from the company's " +
                "own data. Kirona is a product of Otamot GmbH built by technolog.ch — the same team behind " +
                "MyDinner — and I work on its web side only: the Blazor product UI and the public multilingual " +
                "website. No mobile on this one.",
            Stack = ["C#", ".NET 10", "Blazor Web App", "EF Core", "SQL Server · PostgreSQL · SQLite", "SignalR", "Hangfire", "QuestPDF", "Azure DevOps"],
            Metrics = ["Website in 5 languages", "Product UI in 10 languages", "Swiss QR invoicing", "Web only — same stack as MyDinner"],
            Highlights =
            [
                "Built kirona.ai from scratch as a Blazor app: launch page and sub-pages — product, AI, industries, pricing, partners, investors, download, contact and legal — in German, English, Spanish, Italian and Portuguese.",
                "Redesigned the ERP dashboard: full-width layout, reports as a cockpit and a reworked data analyzer.",
                "Translated the core modules — quotes, invoices, delivery notes, production, warehouse, shop and customer portal — into ten languages.",
                "Support chat widget with availability states (online, busy, inbox) for the AI support surface.",
                "Fixed demo-data loading on an already-started database and a round of UI defects found with the test company and the light theme."
            ],
            CaseStudy =
            [
                new("Where I fit",
                    "Kirona uses the stack I already run every day on MyDinner — Blazor, EF Core, SQL Server, SignalR — " +
                    "so I joined on the web side: the product's Blazor UI and the public site. The mobile app is " +
                    "someone else's; this is strictly web."),
                new("The website",
                    "kirona.ai started as an empty Blazor project. Shared layout, page hero, card grids and CTA bands " +
                    "as components; copy in per-language JSON resources so marketing can edit a sentence without " +
                    "touching Razor."),
                new("The product UI",
                    "Dashboard, reports cockpit, data analyzer and a long list of module screens — redesigned for " +
                    "full screen width and translated into ten languages, with fixes landing through Azure DevOps " +
                    "branches merged from master.")
            ],
            Links = [new("Visit site", "https://kirona.ai/es", "external")]
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
            Slug = "fonetica-unefm",
            Name = "Website de Fonética I",
            Tagline = "Phonetics training platform for UNEFM students",
            Role = "Freelance · built from scratch",
            Period = "2026",
            Kind = ProjectKind.Product,
            Accent = "#3b82f6",
            Featured = true,
            Shot = "img/shots/fonetica-unefm.webp",
            Summary =
                "A backend-free learning platform for the English phonetics course at UNEFM Carirubana, built for " +
                "a degree thesis. Four task-based modules with video lessons, readings, interactive practice, quizzes " +
                "and a recorded Speaking Challenge per module. Every text is Markdown and every list is JSON, so the " +
                "teacher updates the course without touching code.",
            Stack = ["Blazor WebAssembly", ".NET 10", "C#", "Markdig", "PWA · service worker", "GitHub Actions", "GitHub Pages", "Google Analytics 4"],
            Metrics = ["Zero backend, zero hosting cost", "Offline-capable PWA", "Content in Markdown + JSON", "Deployed on every push"],
            Highlights =
            [
                "Standalone Blazor WebAssembly: a static site, no accounts, no database, hosted free on GitHub Pages.",
                "Content lives in wwwroot/contenido as Markdown and JSON — IPA notation via inline code, highlights via ==text== — with a written guide for the teacher.",
                "YouTube lessons load lazily (thumbnail first, youtube-nocookie player on tap) and open in-page so students never leave the site.",
                "Service worker tuned for slow connections: app shell cache-first, content network-first, no web fonts.",
                "Speaking Challenges collected through a Google Form per module; usage metrics logged to GA4 for the thesis.",
                "GitHub Actions builds and publishes on every push to main, with the base path and a 404 fallback handled for Pages."
            ],
            CaseStudy =
            [
                new("The brief",
                    "A phonetics teacher needed a training space her students could reach from cheap phones on slow " +
                    "connections, with no budget for hosting and no developer on call afterwards."),
                new("Why Blazor WebAssembly, static",
                    "C# end to end, zero servers to pay for, and a PWA that keeps working once loaded. GitHub Pages " +
                    "hosts it for free and GitHub Actions rebuilds it on every push."),
                new("Editable without me",
                    "The platform reads its own content at runtime from Markdown and JSON, so adding a module or " +
                    "fixing a sentence is a file edit, not a release.")
            ],
            Links =
            [
                new("Visit site", "https://alucardsanin.github.io/YolaProfeWebApp/", "external"),
                new("Source", "https://github.com/AlucardSanin/YolaProfeWebApp", "github")
            ]
        },

        new()
        {
            Slug = "corvita",
            Name = "Corvita Recovery",
            Tagline = "Website for a sports recovery and biohacking lounge in Miami",
            Role = "Freelance · design and build from scratch",
            Period = "2026",
            Kind = ProjectKind.Landing,
            Accent = "#e11d48",
            Featured = true,
            Shot = "img/shots/corvita.webp",
            Summary =
                "A bilingual, multi-page site for a recovery and biohacking lounge in Hialeah: services, memberships, " +
                "a 30-day protocol, supplements, team, FAQs and gift cards, with online booking, WhatsApp contact " +
                "and financing built in. Taken from desktop design concepts to a live domain, then kept in sync " +
                "with the production server as the client's requests came in.",
            Stack = ["HTML5", "CSS design system", "Vanilla JavaScript", "JSON-driven content", "PHP endpoints", "Vagaro booking embeds", "Affirm financing", "Figma handoff", "SEO · sitemap"],
            Metrics = ["9 public routes", "English & Spanish", "Booking + memberships embedded", "Concepts → production"],
            Highlights =
            [
                "Three desktop concepts (editorial, performance, wellness) presented to the client before a line of production code.",
                "A small CSS design system — typography, color, effects, polish — shared across every route instead of per-page styles.",
                "Copy and lists (team, FAQs, services, memberships) come from JSON data files, so updates are edits, not rewrites.",
                "Vagaro booking and membership widgets, WhatsApp and call-now actions, Google reviews and Affirm pay-over-time.",
                "Every change verified against the live server: public files downloaded and compared by hash before and after each sync."
            ],
            CaseStudy =
            [
                new("The brief",
                    "A real business with real bookings needed a site that sells the experience — intro session, " +
                    "memberships, 30-day protocol — and gets a visitor into the booking flow in one tap, in " +
                    "English or Spanish."),
                new("The approach",
                    "Design first: concepts the client could react to, then a production build with a shared " +
                    "stylesheet system and JSON content. Launched under /new/ beside the existing site, then " +
                    "promoted to the root routes once approved.")
            ],
            Links = [new("Visit site", "https://corvitarn.com/", "external")]
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
