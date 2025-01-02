using MachinePark.Shared.Models;

namespace MachinePark.App.Services
{
    public class GlobalMachineList
    {
        public List<Machine> machines = new();

        public event Action? OnChange;

        public void Add(Machine machine)
        {
            machines.Add(machine);
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
