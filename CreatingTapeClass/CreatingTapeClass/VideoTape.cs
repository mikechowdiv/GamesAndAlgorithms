using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTapeClass
{
    class VideoTape : Tape
    {
        public int PlayTime { get; set; }
        public VideoTape(int length, int width, int playTime)
            : base(length, width)
        {
            PlayTime = playTime;
        }

        public override string ToString()
        {
            return String.Format("{0}\nPlay Time: {1}", base.ToString(), PlayTime);
        }
    }
}
