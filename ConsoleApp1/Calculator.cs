using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProGitForProgrammers
{
    public class Calculator
    {
        public int Add(int lhs, int rhs)
        {
            return lhs + rhs;
        }
        public int Subtract(int lhs, int rhs)
        {
            return lhs - rhs;
        }
        public int Divide(int lhs, int rhs)
        {
            return rhs * 10;
        }

    }
}
