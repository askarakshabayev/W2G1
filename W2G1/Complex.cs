using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2G1
{
    /// <summary>
    /// Complex number, example a/b
    /// </summary>
    class Complex
    {
        public int a, b;

        public Complex(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }

        /// <summary>
        /// 5/6 + 1/2 = 6/8 (wrong)
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public Complex Add(Complex complex2) // this -> a, complex2 -> b
        {                                           
            Complex result = new Complex(this.a + complex2.a, this.b + complex2.b);
            return result;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(c1.a + c2.a, c1.b + c2.b);
            c.Simplify();
            return c;
        }

        // 24/36
        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while (_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a % _b;
                else
                    _b = _b % _a;
            }
            int nod = _a + _b;
            a /= nod;
            b /= nod;
        }
    }
}
