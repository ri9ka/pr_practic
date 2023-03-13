using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    class Line
    {
        protected tochka Firsttochka= new tochka();
        protected tochka Secondtochka = new tochka();
        protected double x, y;
        public Line()
        {
            x = 0;
            y = 0;
            this.Firsttochka = new tochka(x, y);
            this.Secondtochka = new tochka(x, y);
        }

        public Line(tochka toch1, tochka toch2)
        {
            this.Firsttochka = toch1;
            this.Secondtochka = toch2;
        }
        public tochka TochkaFirst
        {
            get { return Firsttochka; }
            set { Firsttochka = value; }
        }

        public tochka TochkaSecond
        {
            get { return Secondtochka; }
            set { Secondtochka = value; }
        }
        public override string ToString()
        {
            string PatternWrite = $"Линия: {Firsttochka.ToString()}и{Secondtochka.ToString()}";
            return PatternWrite;
        }

        public override bool Equals(object line)
        {
            if (line == null) return false;
            Line _line = (Line)line;
            if (_line.Firsttochka == Firsttochka && _line.Secondtochka == Secondtochka) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Line lin1, Line lin2)
        {
            return lin1.Equals(lin2);
        }
        public static bool operator !=(Line lin1, Line lin2)
        {
            return !(lin1.Equals(lin2));
        }

        public static Line operator +(Line lin1, Line lin2)
        {
            return new Line(lin1.Firsttochka + lin2.Firsttochka, lin1.Secondtochka = lin2.Secondtochka);
        }
    }
}