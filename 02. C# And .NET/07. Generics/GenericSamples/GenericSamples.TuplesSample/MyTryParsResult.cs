using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.TuplesSample
{
    public class MyTryParsResult
    {
        public int Value { get; set; }
        public bool IsSuccess { get; set; }
    }

    public class MyMinMaxResult
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class MyTowItemResult<TItem1, TItem2>
    {
        public MyTowItemResult(TItem1 item1, TItem2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
        public TItem1 Item1 { get; set; }
        public TItem2 Item2 { get; set; }
    }

    public class MyThreeItemResult<TItem1, TItem2,Titem3>
    {
        public MyThreeItemResult(TItem1 item1, TItem2 item2,Titem3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;

        }
        public TItem1 Item1 { get; set; }
        public TItem2 Item2 { get; set; }
        public Titem3 Item3 { get; set; }
    }
}
