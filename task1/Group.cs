using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Group
    {
        private string _no;
        public string No { get; set; }
        public Type GroupType { get; set; }
        public Group(Type type)
        {
            GroupType = type;
        }

    }
}
