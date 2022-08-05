using System.Collections.Generic;

namespace UniversityRoster.Models
{
  public class Machine
    {
        public Machine()
        {
            this.JoinEntities = new HashSet<MachineStudent>();
        }

        public int MachineId { get; set; }
        public string Class { get; set; }
        
        public virtual ICollection<MachineStudent> JoinEntities { get; set; }

    }
}