using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionSamples.BuiltIns
{
    public class Person
    {
        //public Person(string firstName,int age)
        //{
            
        //    if(string.IsNullOrEmpty(firstName))
        //    {
        //        throw new ArgumentNullException(nameof(firstName));
        //    }
        //    if(age < 0 || age > 100) {
        //        throw new ArgumentOutOfRangeException(nameof(age));
        //    }
            
        //    throw new ArgumentNullException(); 

        //}

        public void CallMe(long count)
        {
            Console.WriteLine(count);
           count++;
            CallMe(count);
        }
    }
}
