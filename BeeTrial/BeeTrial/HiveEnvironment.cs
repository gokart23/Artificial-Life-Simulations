using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTrial
{
    class HiveEnvironment
    {
        private Random rGen;
        private Rectangle[] clumps;

        public int numClumps { get; private set; }

        public HiveEnvironment()
        {
            rGen = new Random();

            this.numClumps = (int)rGen.Next(1, 6);
            clumps = new Rectangle[numClumps];

            for (int i = 0; i < numClumps; i++)
            {
                clumps[i] = new Rectangle((int)rGen.Next(10, 100), (int)rGen.Next(10, 50), (int)rGen.Next(4, 20), (int)rGen.Next(4, 20));                
            }
        }

        public bool hasFoundClump(Point position)
        {
            for (int i = 0; i < numClumps; i++)
            {
                if (clumps[i].Contains(position))
                    return true;
            }

            return false;
        }

        public Rectangle clump(int index)
        {
            return clumps[index];
        }
    }
}