using AgileWorks.Data;
using AgileWorks.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileWorks.Facade
{
    public static class TaskViewFactory
    {
            public static TaskView Create(TaskObject o)
            {
                var animal = new TaskView
                {
                    Id = o._task.Id,
                    Name = o._task.Name,
                    Description = o._task.Description,
                    ValidFrom = o._task.ValidFrom,
                    ValidTo = o._task.ValidTo

                };

                return animal;
            }

            public static TaskObject Create(TaskView v)
            {

                var d = new TaskData
                {
                    Id = v.Id,
                    Name = v.Name,
                    Description = v.Description,
                    ValidFrom = v.ValidFrom,
                    ValidTo = v.ValidTo

                };
                return new TaskObject(d);
            }
    }
}
