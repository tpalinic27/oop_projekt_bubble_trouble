using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public abstract class Likovi : Sprite
    {
        public Likovi(string path, int xcor, int ycor)
            : base(path, xcor, ycor)
        {

        }
    }
    public class Devil : Likovi
    {
        public Devil(string path, int xcor, int ycor)
            : base(path, xcor, ycor)
        {
            this.speed = 50;
            this.life = 3;
            this.ArrowReady = true;
        }
        protected int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        protected int life;
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public bool ArrowReady;
        public override int X
        {
            get { return x; }
            set
            {

                if (value <= GameOptions.LeftEdge)
                    this.x = GameOptions.LeftEdge;
                else if (value >= GameOptions.RightEdge - this.Width)
                    this.x = GameOptions.RightEdge - this.Width;
                else
                    this.x = value;
            }
        }
    }
    public class Bubble : Likovi
    {

        public Bubble(string path, int xcor, int ycor)
            : base(path, xcor, ycor)
        {
            this.speed = 1;
            this.life = 2;
        }


        protected int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        protected int life;
        public int Life
        {
            get { return life; }
            set { life = value; }
        }
        public override int X
        {
            get { return x; }
            set
            {
                //if (value <= GameOptions.LeftEdge)
                //    this.x = GameOptions.LeftEdge;
                //else if (value >= GameOptions.RightEdge - this.Width)
                //    this.x = GameOptions.RightEdge - this.Width;
                //else
                this.x = value;
            }
        }
        public override int Y
        {
            get { return y; }
            set
            {
                //if (value <= GameOptions.UpEdge)
                //    this.y = GameOptions.UpEdge;
                //else if (value >= GameOptions.DownEdge - this.Heigth)
                //    this.y = GameOptions.DownEdge - this.Heigth;
                //else
                this.y = value;
            }
        }

    }
    public class Weapon : Sprite
    {
        public Weapon(string path, int xcor, int ycor)
            : base(path, xcor, ycor)
        {

        }
    }
    public class Arrow : Weapon
    {
        public Arrow(string path, int xcor, int ycor)
            : base(path, xcor, ycor)
        {
            this.speed = 25;
        }
        protected int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }
}
