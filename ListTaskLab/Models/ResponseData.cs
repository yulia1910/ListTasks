using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ListTaskLab.Models
{
    public class ResponseData
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }
}
