using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10229540_PROG7312_POE
{
    public class Event
    {

        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public Event(string name, string category, DateTime date, string location)
        {
            Name = name;
            Category = category;
            Date = date;
            Location = location;
        }


    }
}
