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