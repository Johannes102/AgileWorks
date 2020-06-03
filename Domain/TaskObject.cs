using System;
using System.Collections.Generic;
using System.Text;
using AgileWorks.Data;

namespace AgileWorks.Domain
{
    public class TaskObject
    {
        public readonly TaskData _task;

        public TaskObject (TaskData task)
        {
            _task = task;
        }
    }
}
