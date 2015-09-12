using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTrial
{
    class BeeHive
    {
        public int Honey { get; private set; }
        public int numBees { get; set; }
        public int hiveHours { get; private set; }
        public Point Entry { get; private set; }
        public bool isDay { get; private set; }
        public volatile bool run;
        
        private Bee[] bees;
        private Random rGen;
        private HiveEnvironment environment;
        private Form1 form;

        public BeeHive(int numBees, int Honey, Point Entry, HiveEnvironment environment, Form1 form)
        {
            bees = new Bee[numBees];
            this.Honey = Honey;
            this.Entry = Entry;
            this.environment = environment;
            this.form = form;
            this.numBees = numBees;

            rGen = new Random();
            run = true;
            isDay = true;

            for (int i = 0; i < numBees; i++)
            {
                bees[i] = new Bee(i, this.rGen, this);
            }
        }

        public void go()
        {
            
            {
                for (int i = 0; i < numBees; i++)
                {
                    bees[i].updateState();
                }
                
                //Console.WriteLine(bees[0].state + " ");
                hiveHours++;
                if (hiveHours % 12 == 0)
                    isDay = !isDay;           
            }
        }

        public bool inClump(Point position)
        {
            return this.environment.hasFoundClump(position);
        }

        public void stop()
        {
            run = false;
        }

        public bool eatHoney(Bee bee)
        {
            this.Honey -= bee.Appetite;
            if (this.Honey >= 0)
                return true;
            else
                return false;
        }

        public Bee getBee(int beeNumber)
        {
            return bees[beeNumber];
        }

        public void addHoney(Bee bee)
        {
            this.Honey += bee.getHoney();
        }
    }
}
