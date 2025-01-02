using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinePark.Shared.Dtos
{
    public record MachineDto
    {
        public string? Name { get; set; }
        public string Location { get; set; }
        public DateTime Edited { get; set; }
        public bool Status { get; set; }
    }
}
