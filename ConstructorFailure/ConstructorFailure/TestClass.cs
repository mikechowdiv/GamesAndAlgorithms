using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorFailure
{
    class TestClass
    {
        private int _x;
        private int _y;
        private int _total;

        public TestClass(int x, int y)
        {
            try
            {
                _x = x;
                _y = y;
                _total = _x / _y;
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException (ex.Message + "\nyou tried to pass " + _x + " and " + _y);
            }
        }
    }
}
