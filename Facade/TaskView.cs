using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AgileWorks.Facade
{
    public class TaskView
    {
        public string Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string? Description { get; set; }

        [DisplayName("Created")]
        public DateTime ValidFrom { get; set; }

        [DisplayName("Deadline")]
        public DateTime ValidTo { get; set; }
    }
}
