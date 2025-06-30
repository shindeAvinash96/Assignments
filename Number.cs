using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceWithCalisthenics
{
    public class Number
    {
        private readonly int value;

        public Number(int value)
        {
            this.value = value;
        }

        public bool IsOne()
        {
            return value == 1;
        }

        public int ToInt()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
