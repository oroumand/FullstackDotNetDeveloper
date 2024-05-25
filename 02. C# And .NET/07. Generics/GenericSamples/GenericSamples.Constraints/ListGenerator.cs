using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.Constraints
{
    public class ListGenerator<T> where T : new()
    {
        public List<T> GenerateListWithRandomSize()
        {
            int random = new Random().Next(100);
            List<T> list = new List<T>(random);
            for (int i = 0; i < random; i++)
            {

                list[i] = new T();
            }
            return list;
        }
    }

    public class ListPersonGenerator<TPerson> where TPerson : Person, new()
    {
        public List<TPerson> GenerateListWithRandomSize()
        {
            int random = new Random().Next(100);
            List<TPerson> list = new List<TPerson>(random);
            for (int i = 0; i < random; i++)
            {


                list[i] = new TPerson();
            }
            return list;
        }
    }
    public class ListPrintablePersonGenerator<TPerson>
        where TPerson : Person, MyInterface, new()
    {
        public List<TPerson> GenerateListWithRandomSize()
        {
            int random = new Random().Next(100);
            List<TPerson> list = new List<TPerson>(random);
            for (int i = 0; i < random; i++)
            {


                list[i] = new TPerson();
            }
            return list;
        }
    }

    public class ListPrintablePersonGenerator<TPerson, U>
    where TPerson : Person, MyInterface, new()
    where U : INumber<U>
    {
        public List<TPerson> GenerateListWithRandomSize()
        {
            int random = new Random().Next(100);
            List<TPerson> list = new List<TPerson>(random);
            for (int i = 0; i < random; i++)
            {


                list[i] = new TPerson();
            }
            return list;
        }
    }
}
