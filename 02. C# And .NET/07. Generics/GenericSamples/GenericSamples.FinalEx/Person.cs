using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.FinalEx
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }

    }

    public class InquiryPerson
    {
        private readonly CustomeCache<string, Person> _cache = new CustomeCache<string, Person>();
        public Person Get(string NationalCode)
        {
            return _cache.Get(NationalCode, GetFromWebService);

        }

        private Person GetFromWebService(string NationalCode)
        {
            System.Threading.Thread.Sleep(3000);
            return new Person
            {
                Id = DateTime.Now.Ticks,
                FirstName = "FirstName",
                LastName = "LastName",
                NationalCode = NationalCode,
            };

        }
    }
}
