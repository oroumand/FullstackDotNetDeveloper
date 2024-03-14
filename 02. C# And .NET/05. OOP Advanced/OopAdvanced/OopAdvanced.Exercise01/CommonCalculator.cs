using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAdvanced.Exercise01
{
    public class CommonCalculator
    {        
        public int Calculate(List<int> ints)
        {
            var result = 0;
            foreach (var i in ints)
            {
                if (CehckNeedAdd(i))
                {
                    result += i;

                }
            }
            return result;
        }

        protected virtual bool CehckNeedAdd(int i)
        {
            return true;
        }
    }

    public class EvenCalculator : CommonCalculator
    {
        protected override bool CehckNeedAdd(int i)
        {
            return i > 0;
        }
    }

    public class OddCalculator : CommonCalculator
    {
        protected override bool CehckNeedAdd(int i)
        {
            return i < 0;
        }
    }
}
