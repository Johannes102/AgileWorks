using AgileWorks.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgileWorks.Infra
{
    public class DbInitializer
    {
        public static void Initialize(ApDbContext context)
        {

            if (context.Tasks.Any())
            {
                return;
            }

            var tasks = new TaskData[]
            {
                new TaskData{Id=Guid.NewGuid().ToString(), Name="Schoolwork", Description="", ValidFrom=DateTime.Now, ValidTo= new DateTime(2020, 05, 29, 13, 00, 00), Completed = false},
                new TaskData{Id=Guid.NewGuid().ToString(), Name="Gym", Description="", ValidFrom=DateTime.Now, ValidTo= new DateTime(2020, 05, 29, 01, 00, 00), Completed = false},
                new TaskData{Id=Guid.NewGuid().ToString(), Name="Read", Description="", ValidFrom=DateTime.Now, ValidTo= new DateTime(2020, 05, 30, 6, 00, 00), Completed = false},
            };

            context.Tasks.AddRange(tasks);
            context.SaveChanges();
        }
    }
}
