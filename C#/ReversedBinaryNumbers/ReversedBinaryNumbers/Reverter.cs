using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedBinaryNumbers
{
    public class Reverter
    {
        public int Revert(int value)
        {
            return RevertFirstImplementation(value);
        }

        private int RevertFirstImplementation(int value)
        {
            if (value < 1 || value > 1000000000)
            {
                throw new ArgumentOutOfRangeException("value");
            }

            var byteList = new List<int>();
            var newValue = value;

            while (newValue > 0)
            {
                var tempValue = newValue / 2;
                var remain = newValue % 2;
                newValue = tempValue;

                byteList.Add(remain);
            }

            var byteArray = byteList.ToArray();

            var revertedValue = 0;
            var power = 1;
            for (int i = byteArray.Length - 1; i >= 0; i--)
            {
                revertedValue += byteArray[i] * power;
                power *= 2;
            }

            return revertedValue;
        }
    }
}
