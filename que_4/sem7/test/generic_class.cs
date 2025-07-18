using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class generic_class<T>
    {
        // T is the type parameter
        


      

        public T Add(T a, T b)
        {
          
            dynamic x = a;
            dynamic y = b;

            return (T)(x + y);
        }

        public T sub(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;

            return (T)(x - y);
        }

        public T mul(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;

            return (T)(x * y);
        }

        public T div(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;

            return (T)(x / y);
        }
    }
}
