# Happy Tails — Pet Companion

**C# · Windows Forms · Object-Oriented Programming · SQL Server**

A virtual-pet desktop application developed for **CIS 305: Application Programming II** at Flagler College.

## Project overview

Happy Tails allows users to select and customize a dog, cat, pig, or hedgehog and interact with their virtual pet by feeding, playing, and cuddling. The application includes mood check-ins and a mood-history screen backed by a SQL Server database. The interface was developed with Windows Forms, while the pet types use object-oriented C# classes and inheritance.

## Main features

- **Pet selection and customization:** Choose a pet and personalize its details.
- **Interactive dashboard:** Feed, play with, or cuddle the selected pet.
- **Mood check-in:** Record the pet's mood through a dedicated form.
- **Mood history:** View stored records through a database-connected interface.
- **Object-oriented structure:** Share behavior across pet types through a common base class and animal-specific classes.

## Browse the application code

**Start here:** [Open the Visual Studio solution](../Pet%20Companion.sln) or explore the key files below.

| File | What it contains |
| --- | --- |
| [`WelcomeScreen.cs`](../WelcomeScreen.cs) | Pet selection, customization, and input handling |
| [`FormDashboard.cs`](../FormDashboard.cs) | Main pet dashboard and interaction controls |
| [`MoodCheckInForm.cs`](../MoodCheckInForm.cs) | Mood selection and check-in form |
| [`ViewMoodHistory.cs`](../ViewMoodHistory.cs) | Database-connected mood-history interface |
| [`Pet Companion.sln`](../Pet%20Companion.sln) | Visual Studio solution |
| [`Pet Companion.csproj`](../Pet%20Companion.csproj) | Project configuration and build references |
| [`App.config`](../App.config) | Database connection configuration with public-safe placeholders |

The uploaded application files are currently in the [repository's main directory](../), while this page provides a dedicated guide to the project. The application also uses supporting model classes, form designer files, and image resources.

## Technologies used

C# · .NET Framework 4.8.1 · Windows Forms · Object-oriented programming · SQL Server · ADO.NET · Visual Studio

## Running the application

1. On a Windows computer, open [`Pet Companion.sln`](../Pet%20Companion.sln) in Visual Studio with .NET Framework 4.8.1 development support.
2. Build the solution to open the application.
3. For database-dependent mood-history features, configure a SQL Server instance and replace the placeholder values in your local `App.config`. Do not upload real credentials.

The project has not been independently compiled or executed here. Because this is a Windows desktop application, GitHub displays its source code but does not run the application in the browser.

---

[**Back to the full Data Science portfolio**](../)
