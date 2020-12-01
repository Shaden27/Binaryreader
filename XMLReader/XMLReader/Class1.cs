using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLReader
{
    [Serializable]
    public class Employee
    {
        public int empID;
        public string empName;
        public string salary;

        public override string ToString()
        {
            return "ID = " + empID + " Name = " + empName + " Salary = " + salary + "\n";
        }
    }
}
