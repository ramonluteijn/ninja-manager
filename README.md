# ninja-manager

## refresh package 
- Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -> versie 8.0.0

in je program.cs: 
even onder de builder.Services.AddControllersWithViews();

- builder.Services.AddRazorPages();
- builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

## commandline code creator package
-Microsoft.EntityFrameworkCore.Tools -> versie 8.0.0

dotnet tool install -g dotnet-aspnet-codegenerator

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

## database 
in appsettings.json
de default connection string aanpassen naar jouw server

## database migratie
### database tabel / info maken
dotnet ef migrations add "naam van je migratie"
vb: dotnet ef migrations add InitialCreate

het is mogelijk om via een migratie ook alvast data in te voegen, maar voor begin zullen we waarschijnlijk via seeder werken.



### database update
dotnet ef database update