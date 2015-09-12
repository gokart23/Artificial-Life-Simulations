using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeTrial
{
    public enum State
    {
        REST,
        SEEK,
        COLLECT,
        RETURN,
        DEAD
    }

    class Bee
    {
        public int Appetite { get; private set; }
        public int Number { get; private set; }
        public State state { get; private set; }
        public Point position { get; private set; }

        private int honey = 0;
        private bool eaten = false;
        private int counter = 3;
        private Random rGen;
        private BeeHive hive;

        public Bee(int num, Random rGen, BeeHive hive)
        {
            this.Number = num;
            this.rGen = rGen;
            this.hive = hive;
            this.position = hive.Entry;

            this.state = (State)((int)rGen.Next(0, 2));
            this.Appetite = (int)rGen.Next(10, 50);
        }

        public int getHoney()
        {
            int temp = honey;
            honey = 0;
            return temp;
        }

        public void updateState()
        {
            switch(state)
            {
                case State.SEEK:
                    if (!hive.isDay)
                    {
                        this.state = State.RETURN;
                    }
                    else
                    {
                        if (hive.inClump(this.position))
                        {
                            this.state = State.COLLECT;
                        }
                        else
                        {
                            position = new Point(position.X + (int)(rGen.Next(0, 10)), position.Y + (int)(rGen.Next(0, 10)));
                            
                            if (position.X < 0 || position.Y < 0)
                                position = new Point(0, 0);

                        }
                    }
                    if (eaten)
                        eaten = false;
                    break;

                case State.REST:
                    if(hive.isDay)
                    {
                        this.state = (State)((int)rGen.Next(0, 4));
                    }
                    else
                    {
                        if (!eaten)
                        {
                            if(!hive.eatHoney(this))
                            {
                                this.state = State.DEAD;
                            }
                            else
                            {
                                eaten = true;
                            }
                        }
                    }                
                    break;

                case State.RETURN:
                    if (eaten)
                        eaten = false;

                    if(this.position == hive.Entry)
                    {
                        if(honey > 0)
                            Console.WriteLine("Bee#" + this.Number + " added " + this.honey + " units");
                        
                        hive.addHoney(this);                                                
                        this.state = State.REST;
                    }
                    else
                    {
                        float slope = (this.position.Y - hive.Entry.Y) / (float)(this.position.X - hive.Entry.X);
                        float yIntercept = (this.position.Y + (slope) * this.position.X);

                        int newX = -(int)rGen.Next(0, 6) + this.position.X;
                        int newY = (int)(yIntercept + slope * newX);

                        this.position = new Point(newX, newY);

                        //if (position.X < 0 || position.Y < 0)
                        //    position = new Point(0, 0);
                    }
                    break;

                case State.COLLECT:
                    if (hive.inClump(this.position))
                    {
                        if (counter <= 0)
                        {
                            this.state = State.RETURN;
                            this.honey = (int)rGen.Next(30, 200);
                            counter = 50;
                        }
                        else
                        {
                            counter--;
                        }
                    }
                    else
                    {
                        this.state = (State)((int)rGen.Next(0, 2));
                    }
                    break;

                case State.DEAD:
                    break;
            }
        }
    }
}
