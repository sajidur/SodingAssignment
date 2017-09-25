using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SodingAssignment.Models
{
    public class SodingTask
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateUpdated { get; set; }
    }
}