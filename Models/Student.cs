using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIdemo.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
