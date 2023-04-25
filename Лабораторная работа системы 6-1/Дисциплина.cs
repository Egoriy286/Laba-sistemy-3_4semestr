using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_системы_6_1
{
    public class Дисциплина
    {
        public string Name { get; set; }
        public string volHours { get; set; }

        public Дисциплина(string name, string volhours)
        {
            Name = name;
            volHours = volhours;
        }
    }
}
