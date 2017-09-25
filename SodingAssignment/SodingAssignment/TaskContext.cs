using SodingAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SodingAssignment
{
    public class TaskContext:DbContext
    {
        public TaskContext(): base()
        {

        }
        public DbSet<SodingTask> Students { get; set; }

    }
}