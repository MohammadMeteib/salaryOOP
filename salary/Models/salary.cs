using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary.Models
{
    public class Salary
    {
        public int Add(int x, int y)
        { return + x + y; }

        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public double Add(double x, double y, double z) { return x + y + z; }
        public int Add(int salaryy, int workhours, int hourrate, int total)
        {
           
            return  salaryy + (workhours * hourrate);
          
        }

    }

}
