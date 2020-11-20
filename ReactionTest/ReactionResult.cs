using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest
{
    public class ReactionResult
    {
        public int[] result = new int[3];
        public int middleValue;
        public int valueMS;
        public string logValue;
        public ReactionResult(int r)
        {
            valueMS = r;
            logValue = r.ToString() + "мс";
        }
        public ReactionResult(int[] v, int[] r)
        {
            int temp = r[0];
            for (int i = 0; i < 2; i++)
            {
                if (r[i] > r[i+1])
                {
                    temp = r[i];
                    r[i] = r[i+1];
                    r[i+1] = temp;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (v[i]>r[i])
                {
                    temp = v[i] - r[i];
                }
                else
                {
                    temp = r[i] - v[i];
                }
                if (temp > 180)
                {
                    this.result[i] = 360 - temp;
                }
                else
                {
                    this.result[i] = temp;
                }
            }

            temp = 0;
            for (int i = 0; i < 3; i++)
            {
                temp += this.result[i];
            }
            this.middleValue = temp / 3;
            this.valueMS = temp * 10 / 3;
            this.logValue = this.valueMS.ToString() + "мс";
        }
    }
}
