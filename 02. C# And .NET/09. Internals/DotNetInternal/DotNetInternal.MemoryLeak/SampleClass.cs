using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInternal.MemoryLeak
{
    public class SampleClass
    {
        private static List<SampleClass> samples = new List<SampleClass>();

        public static int InstanceCount => samples.Count;

        public SampleClass()
        {
            samples.Add(this);
        }

    }
}
