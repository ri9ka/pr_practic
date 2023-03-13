using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    class ColoredTochka : tochka
    {
        string color;
        public ColoredTochka() : base()
        {
            color = "pink";
        }

        public ColoredTochka(string color, double x) : base(x)
        {
            this.color = color;
        }
        public ColoredTochka(double x) : base(x)
        {
            color = "pink";
        }
        public ColoredTochka(string color, double x, double y) : base(x, y)
        {
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public override string ToString()
        {
            string PatternWrite = $"\nКоординаты color;x;y [{color};{x};{y}]\n";
            return PatternWrite;
        }

        public override bool Equals(object ct)
        {
            ColoredTochka _coloredtochka = (ColoredTochka)ct;
            if (this.x == _coloredtochka.x && this.y == _coloredtochka.y && this.color == _coloredtochka.color) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(ColoredTochka a, ColoredTochka b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(ColoredTochka a, ColoredTochka b)
        {
            return !(a.Equals(b));
        }
    }
}
