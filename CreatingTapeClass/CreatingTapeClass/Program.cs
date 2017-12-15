using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTapeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var tape = new Tape(100, 10);
            var videoTape = new VideoTape(50, 5, 200);
            var adhesiveTape = new AdhesiveType(500, 8, 2);

            Console.WriteLine(tape);
            Console.WriteLine(videoTape);
            Console.WriteLine(adhesiveTape);

            Console.ReadLine();
        }
    }
}
