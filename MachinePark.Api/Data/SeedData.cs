using MachinePark.Shared.Models;

namespace MachinePark.Api.Data
{
    public class SeedData
    {
        private static ApiContext context = default!;

        public static async Task Init(ApiContext _context)
        {
            context = _context;
            if (context.Machine.Any()) return;

            var machines = GenerateMachines();
            await context.AddRangeAsync(machines);

            await context.SaveChangesAsync();
        }

        private static IEnumerable<Machine> GenerateMachines()
        {
            var machines = new List<Machine>
            {
                new Machine { Name = "ab12-cd34-ef56", Location = "Stockholm", Edited = DateTime.Today, Status = true },
                new Machine { Name = "gh78-ij90-kl12", Location = "Uppsala", Edited = DateTime.Now, Status = false },
                new Machine { Name = "mn34-op56-qr78", Location = "Stockholm", Edited = DateTime.UtcNow, Status = true }
            };

            return machines;
        }
    }
}
