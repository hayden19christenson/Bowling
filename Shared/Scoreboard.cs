using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingChallenge.Shared
{
    public class Scoreboard
    {
        public List<Frame> Frames;

        public int Total;

        public int currentFrame;

        //Initialized Scoreboard to have its last frame have a possible 3rd roll
        public Scoreboard()
        {
            List<Frame> fullFrames = new List<Frame>();

            for(int i = 0; i < 9; i++)
            {
                fullFrames.Add(new Frame());
            }

            Frame lastFrame = new Frame();
            lastFrame.isLast = true;
            fullFrames.Add(lastFrame);

            Frames = fullFrames;
        }
    }

}
