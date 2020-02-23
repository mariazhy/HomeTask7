using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task_7
{
    class Country
    {
        public Country()
        {
             
        }
        public Country(string country, bool isTelenorSupported)
        {
            Name = country;
            IsTelenorSupported = isTelenorSupported;
        }
        public string Name { get; set; }
        public bool IsTelenorSupported { get; set; }

    }
}
