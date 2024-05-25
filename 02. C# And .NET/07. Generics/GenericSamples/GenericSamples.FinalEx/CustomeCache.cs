using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSamples.FinalEx
{
    public class CustomeCache<TKEy, TValue>
    {
        private readonly Dictionary<TKEy, TValue> keyValuePairs = new Dictionary<TKEy, TValue>();
        public TValue Get(TKEy key, Func<TKEy, TValue> func)
        {
            if (!keyValuePairs.ContainsKey(key))
            {
                var result = func(key);
                keyValuePairs.Add(key, result);
            }
            return keyValuePairs[key];
        }
        public bool Remove(TKEy key)
        {
            if (keyValuePairs.ContainsKey(key))
            {

                keyValuePairs.Remove(key);
                return true;
            }
            return false;
        }
    }
}
