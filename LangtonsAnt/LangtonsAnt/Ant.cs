using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LangtonsAnt
{
    [global::System.Serializable]
    public class InvalidParamException : Exception
    {
        public InvalidParamException() { }
        public InvalidParamException(string message) : base(message) { }
        public InvalidParamException(string message, Exception inner) : base(message, inner) { }
        protected InvalidParamException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    class Ant
    {
        private enum Direction
        {
            Up,
            Down,
            Right,
            Left
        };

        private Point current;
        private Direction direction;
        private AntInterface board;
       

        public Ant(System.Drawing.Point start, AntInterface board)
        {
            current = start;
            this.board = board;
            this.direction = Direction.Up;            
        }

        public void go()
        {
            int counter = 45;

            while(counter != 0)
            {
                try
                {
                    Point temp;
                    if (board.getCurrentImage(current) == LangtonsAnt.Properties.Resources.White)
                    {
                        temp = getNextPoint(true);
                        board.updateState(LangtonsAnt.Properties.Resources.Black, current, temp);
                    }
                    else
                    {
                        temp = getNextPoint(false);
                        board.updateState(LangtonsAnt.Properties.Resources.White, current, temp);
                    }
                    current = temp;
                }
                catch(Exception ex)
                {
                    
                }
                counter--;
            }
        }

        private Point getNextPoint(bool isWhite)
        {
            
            if(isWhite)
            {
                switch(direction)
                {
                    case Direction.Up: 
                        direction = Direction.Right;
                        return new Point(current.X + 1, current.Y);
                    case Direction.Down:
                        direction = Direction.Left;
                        return new Point(current.X - 1, current.Y);
                    case Direction.Right:
                        direction = Direction.Down;
                        return new Point(current.X, current.Y - 1);
                    case Direction.Left:
                        direction = Direction.Up;
                        return new Point(current.X, current.Y + 1);
                }
            }
            else
            {
                switch (direction)
                {
                    case Direction.Down:
                        direction = Direction.Right;
                        return new Point(current.X + 1, current.Y);
                    case Direction.Up:
                        direction = Direction.Left;
                        return new Point(current.X - 1, current.Y);
                    case Direction.Left:
                        direction = Direction.Down;
                        return new Point(current.X, current.Y - 1);
                    case Direction.Right:
                        direction = Direction.Up;
                        return new Point(current.X, current.Y + 1);
                }
            }

            throw new InvalidParamException("Invalid Parameters entered");           
        }
    }
}
