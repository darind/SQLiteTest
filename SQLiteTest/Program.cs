using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace SQLiteTest
{
    class Program
    {
        static async Task Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TestContext>();
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();
            optionsBuilder.UseSqlite(connection);

            var context = new TestContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            Console.WriteLine("BEFORE QUERY");

            var events = await context.Set<Parent>()
                .Include(x => x.Receiver)
                .Where(x => x.SenderId == 5 || x.ReceiverId == 4)
                .ToListAsync();

            Console.WriteLine($"Records count: {events.Count}");
        }
    }
}
