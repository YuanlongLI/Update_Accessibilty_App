using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Update_Accessibility_App
{
    class ComboBox_People
    {
        public ComboBox_People(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayText => $"{Id} - {Name}";
    }
}
