using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTapeClass
{
    class AdhesiveType : Tape
    {
        private int _stickeness;
        public AdhesiveType(int length, int width, int stickeness)
            : base(length, width)
        {
            Stickeness = stickeness;
        }
        
        public int Stickeness
        {
            get { return _stickeness; }
            set
            {
                if (value >= 1 && value <= 10)
                    _stickeness = value;
                else
                    _stickeness = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\nStickeness: {1}", 
                base.ToString(), (Stickeness == 0 ? "Invalid input" : Stickeness.ToString()));
        }
    }
}
