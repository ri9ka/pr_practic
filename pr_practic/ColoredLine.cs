using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    class ColoredLine : Line
    {
        protected string color;
        public ColoredLine() : base()
        {
            color = "red";
        }
        public ColoredLine(tochka tochkaFirst, tochka tochkaSecond) : base(tochkaFirst, tochkaSecond)
        {
            color = "pink";
        }
        public ColoredLine(tochka tochkaFirst, tochka tochkaSecond, string color) : base(tochkaFirst, tochkaSecond)
        {
            this.color = color;
        }
        public override string ToString()
        {
            string PatternWrite = $"\nЛиния и color [{color}]{Firsttochka.ToString()}и{Secondtochka.ToString()}";
            return PatternWrite;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override bool Equals(object colorline)
        {
            if (colorline == null) return false;
            ColoredLine _line = (ColoredLine)colorline;
            if (_line.Firsttochka == Firsttochka && _line.Secondtochka == Secondtochka && _line.color == color) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return colorLine1.Equals(colorLine2);
        }

        public static bool operator !=(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return !(colorLine1.Equals(colorLine2));
        }

        public static ColoredLine operator +(ColoredLine colorLine1, ColoredLine colorLine2)
        {
            return new ColoredLine(colorLine1.Firsttochka + colorLine2.Firsttochka, colorLine1.Secondtochka + colorLine2.Secondtochka, colorLine1.color = colorLine2.color);
        }
    }

}
