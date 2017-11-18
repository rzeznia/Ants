using System;
using System.Collections.Generic;

namespace Ants
{
    class Ant
    {
        public Ant(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        private int lastDirection; // 0-UP, 1-LEFT, 2-RIGHT, 3-DOWN
        private int newDirection; // 0-UP, 1-LEFT, 2-RIGHT, 3-DOWN
        private int tempX;
        private int tempY;
        public void Show(int DESC)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(DESC == 1 ? '*' : ' '); //desc: 0 dla kasowania, 1 dla wpisywania
        }  
        public void Move(Random rndm, List<Ant> antExisted)
        {
            while (true)
            {
                newDirection = rndm.Next(3);
                 if (newDirection + lastDirection == 3)
                    continue;
                break;
            }
            Show(0);
            switch (newDirection)
            {
                case 0:
                {
                       tempY = Y-1;
                       tempX = X;
                        break;
                }
                case 1:
                {
                        tempX = X-1;
                       tempY = Y;
                        break;
                }
                case 2:
                {
                        tempX = X+1;
                       tempY = Y;
                            break;
                }
                case 3:
                {
                        tempY = Y+1;
                       tempX = X;
                        break;
                }
            }
            if (tempY < 1)
                tempY = 20;
            if (tempY > 21)
                tempY = 1;
            if (tempX < 1)
                tempX = 70;
            if (tempX > 70)
                tempX = 1;
            for (int i = 0; i < antExisted.Count; i++)
            {
                if (tempX == antExisted[i].X && tempY == antExisted[i].Y)
                {
                    antExisted.RemoveAt(i);
                    //isUnique = false;
                    break;
                }
            }
            X = tempX;
            Y = tempY;
            Show(1); 
        }
    }
}
    