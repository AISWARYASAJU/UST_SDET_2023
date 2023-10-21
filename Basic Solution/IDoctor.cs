using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Solution
{
    internal interface IDoctor
    {
       
        void AddNewDoctor(int did , string? dname);
        
        void ModifyDoctor(int did, string? dnam);
    }
}
