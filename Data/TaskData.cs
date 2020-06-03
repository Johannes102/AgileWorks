using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace AgileWorks.Data
{
    public class TaskData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool Completed { get; set; }
    }
}
