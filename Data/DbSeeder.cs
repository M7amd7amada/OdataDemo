using Microsoft.EntityFrameworkCore;
using Odata.Models;

namespace Odata.Data;

public static class DbSeeder
{
    public static void SeedData(WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetService<AppDbContext>();

        db!.Demos.AddRange(
            new DemoModel { Name = "Item 1", Number = "123456" },
            new DemoModel { Name = "Item 2", Number = "789012" },
            new DemoModel { Name = "Item 3", Number = "345678" },
            new DemoModel { Name = "Item 4", Number = "901234" },
            new DemoModel { Name = "Item 5", Number = "567890" },
            new DemoModel { Name = "Item 6", Number = "234567" },
            new DemoModel { Name = "Item 7", Number = "890123" },
            new DemoModel { Name = "Item 8", Number = "456789" },
            new DemoModel { Name = "Item 9", Number = "012345" },
            new DemoModel { Name = "Item 10", Number = "678901" },
            new DemoModel { Name = "Item 11", Number = "345678" },
            new DemoModel { Name = "Item 12", Number = "901234" },
            new DemoModel { Name = "Item 13", Number = "567890" },
            new DemoModel { Name = "Item 14", Number = "234567" },
            new DemoModel { Name = "Item 15", Number = "890123" },
            new DemoModel { Name = "Item 16", Number = "456789" },
            new DemoModel { Name = "Item 17", Number = "012345" },
            new DemoModel { Name = "Item 18", Number = "678901" },
            new DemoModel { Name = "Item 19", Number = "345678" },
            new DemoModel { Name = "Item 20", Number = "901234" }
        );

        db.SaveChanges();
    }
}
