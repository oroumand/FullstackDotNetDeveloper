using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    public class Calculator(string name, DateTime createDate)
    {
        string _name = name;
        DateTime _createDate = createDate;

        public Calculator() : this("")
        {
            _name = string.Empty;
            _createDate = DateTime.Now;
        }

        public Calculator(string name) : this(name, DateTime.Now)
        {

        }

        public int Add(int num01, int num02) => num01 + num02;
        public int Add(int num01, int num02, int num03) => num01 + num02 + num03;
        public int Add(int num01, int num02, int num03 = 0, int num04 = 0)
        {
            return num01 + num02 + num03 + num04;
        }
        public long Add(long num01, long num02) => num01 + num02;
        public decimal Add(decimal num01, decimal num02) => num01 + num02;
    }
}
