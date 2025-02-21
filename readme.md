PokemonApp2-Backend
│
├── Controllers
│   ├── PokemonController.cs         # API-Controller für Pokémon-Ressource
│   ├── UserController.cs            # API-Controller für User-Ressource
│
├── Data
│   ├── PokemonDbContext.cs         # DbContext für Entity Framework
│   ├── MigrationFiles              # Migrationsdateien von Entity Framework
│
├── Models
│   ├── Pokemon.cs                  # Model für Pokémon
│   ├── User.cs                     # Model für User
│   ├── UserTeam.cs                 # Model für UserTeams
│
├── Migrations                      # Enthält Migrationsdateien
│
├── Properties
│   ├── launchSettings.json         # Ausführungseinstellungen
│
├── Services
│   ├── PokemonService.cs           # Geschäftslogik für Pokémon-bezogene Operationen
│   ├── UserService.cs              # Geschäftslogik für User-bezogene Operationen
│
├── appsettings.json                # Anwendungskonfiguration
│
├── Program.cs                      # Startpunkt der Anwendung
│
└── Startup.cs                      # (Falls verwendet) Konfiguration der Dienste und Middleware
