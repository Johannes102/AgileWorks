using AgileWorks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileWorks.Facade
{
    public class TaskViewList : List<TaskView>
    {
        public TaskViewList(IEnumerable<TaskObject> list)
        {
            foreach (var task in list)
            {
                Add(TaskViewFactory.Create(task));
            }
        }
    }
}
