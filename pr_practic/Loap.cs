using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_practic
{
    class Loap
    {
        protected int z = 0;
        protected Line[] Lines = new Line[20];
        private bool flag = true;
        public Loap()
        {
            Lines[0] = new Line();
            z = 1;
        }
        public Loap(params Line[] lin)
        {
            Array.Copy(lin, Lines, lin.Length);
            z = lin.Length;
        }
        public override string ToString()
        {
            string PatternWrite = $"\nКол-во углов:{z}\n";
            for (int i = 0; i < z; i++)
            {
                PatternWrite += Lines[i];
            }
            return PatternWrite;
        }
        public override bool Equals(object polygon)
        {
            if (polygon == null) return false;
            Loap _polygon = (Loap)polygon;
            for (int i = 0; i < z; i++)
            {
                if (this.Lines[i].Equals(_polygon.Lines[i]))
                    flag = false;
            }
            return flag;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(Loap polygonFirst, Loap polygonSecond)
        {
            return polygonFirst.Equals(polygonSecond);
        }

        public static bool operator !=(Loap polygonFirst, Loap polygonSecond)
        {
            return !(polygonFirst.Equals(polygonSecond));
        }
    }
}