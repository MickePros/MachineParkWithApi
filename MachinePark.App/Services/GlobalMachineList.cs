using MachinePark.Shared.Dtos;

namespace MachinePark.App.Services
{
    public class GlobalMachineList
    {
        public List<MachineDto> machines = new();

        public event Action? OnChange;

        public void Add(MachineDto machine)
        {
            machines.Add(machine);
            NotifyStateChanged();
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
