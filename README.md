# Happy Tails — Pet Companion

A C# Windows Forms virtual-pet application developed as a final project for **CIS 305: Application Programming II** at Flagler College.

## About the project

Happy Tails lets users select a dog, cat, pig, or hedgehog, customize their pet, and interact through feeding, cuddling, and playing. The application includes mood check-ins, pet imagery, and a mood-history view backed by a SQL Server database.

## Features

- Choose and customize a virtual pet and its favorite toy.
- Interact with the pet using the Windows Forms dashboard.
- Record and display mood information.
- View stored mood history using SQL Server.
- Use a shared abstract `Pet` class and derived `Dog`, `Cat`, `Pig`, and `Hedgehog` classes.

## Technologies and concepts

- **C#**, **Windows Forms**, **.NET Framework 4.8.1**
- Object-oriented programming, inheritance, polymorphism, event handlers, and input validation
- **SQL Server** and ADO.NET (`System.Data.SqlClient`)
- Visual Studio form designer and image resources

## Browse the source code

| Location | Contents |
| --- | --- |
| [`Model/`](Model/) | Base `Pet` class and animal subclasses |
| [`WelcomeScreen.cs`](WelcomeScreen.cs) | Pet selection, customization, and validation |
| [`FormDashboard.cs`](FormDashboard.cs) | Pet interactions and dashboard behavior |
| [`MoodCheckInForm.cs`](MoodCheckInForm.cs) | Mood check-in logic |
| [`ViewMoodHistory.cs`](ViewMoodHistory.cs) | SQL Server mood-history storage and display |
| [`Data/`](Data/) | SQL table-definition scripts |
| `*.Designer.cs` and `*.resx` | Windows Forms designer and UI resources |

## Running locally

1. Use **Windows** with **Visual Studio** and .NET Framework 4.8.1 development support.
2. Open `Pet Companion.sln`.
3. Configure a SQL Server database you control. The scripts in `Data/` provide the `Pets` table schema. **Note:** `SQLQuery1.sql` drops the existing `Pets` table before recreating it; do not run it against a database containing data you want to keep.
4. Edit `App.config` **on your own machine** to replace the placeholder SQL Server connection values. Do not commit your real credentials to GitHub.
5. Build and run the solution in Visual Studio.

**Important:** The database connection in this public copy intentionally contains placeholders. Database-dependent features will not work until you supply a valid local connection. The project has not been independently compiled or run in this environment.

## Project context

This repository preserves the coursework implementation, with only repository packaging, documentation, the solution-file project reference, and the database configuration adjusted for safe public sharing. The code has not been refactored or represented as production-ready software.
