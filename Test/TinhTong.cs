using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TinhTong
    {
        public int TinhTongChan()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 ==0 && i % 8 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
