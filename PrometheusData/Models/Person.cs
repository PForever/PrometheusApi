using System;
using System.Collections.Generic;
using System.Text;

namespace PrometheusData.Models
{

    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        //public InviteInfo InviteInfo { get; set; }
        public string Description { get; set; }
        public Person()
        {
        }
    }
}
