using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactionTest
{
    public class TrafficLightsResult
    {
        public int Result;
        public string Log;
        public TrafficLightsResult(int[] result)
        {
            int i = 0;
            int sum = 0;
            foreach (var item in result)
            {
                sum += item;
                i++;
            }
            this.Result = sum / i;
            this.Log = this.Result.ToString() + "мс";
        }
        public TrafficLightsResult(int result)
        {
            this.Result = result;
            this.Log = this.Result.ToString() + "мс";
        }
    }
}
