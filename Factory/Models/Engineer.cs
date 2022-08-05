using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
namespace Factory.Models
{
    public class Engineer
    {
        public Engineer()
        {
            this.JoinEntities = new HashSet<MachineEngineer>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }

        public virtual ICollection<MachineEngineer> JoinEntities { get;}
    }
}