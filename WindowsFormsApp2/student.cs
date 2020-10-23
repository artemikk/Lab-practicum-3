using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class student
    {
        public double id { get; set; }
        public string name{ get; set; }
        public student()
        {
        }
        public student(double nomer, string fio)
        {
            id = nomer;
            name = fio;
        }
    }
}
