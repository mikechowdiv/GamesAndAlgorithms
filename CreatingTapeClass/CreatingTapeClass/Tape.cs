using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTapeClass
{
    class Tape
    {     
        public Tape(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\nLength: {1}\nWidth: {2}", GetType(), Length, Width);
        }
    }
}
