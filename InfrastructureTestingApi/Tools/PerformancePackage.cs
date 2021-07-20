using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace InfrastructureTestingApi
{
	public class PerformancePackage 
    {
        private Stopwatch stopwatch;
        public double Size { get; set; }
        public string Data { get; set; }
        public double prozessingTime { get; set; }

        public PerformancePackage(int size)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            this.Size = size;
            setSize(size);
            stopwatch.Stop();
            prozessingTime =  stopwatch.Elapsed.TotalMilliseconds;
        }

        private void setSize(int size)
        {
            string oneByte = "0xAABBCC";
            string tenByte = "0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC";
            string hundredByte = "0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC";
            string kiloByte = "0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC0xAABBCC";

            StringBuilder stringBuilder = new StringBuilder();

            while (size > 0)
            {
                if (size > 8000)
                {
                    stringBuilder.Append(kiloByte);
                    size -= 8000; 
                }
                if (size > 800)
                {
                    stringBuilder.Append(hundredByte);
                    size -= 800;
                }
                if (size > 80)
                {
                    stringBuilder.Append(tenByte);
                    size -= 80;
                }
                else 
                {
                    stringBuilder.Append(oneByte);
                    size -= 1;
                }
            }

            Data = stringBuilder.ToString();
        }
    }
}