using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemStatement1
{
    internal class AirQualityIndex
    {
        public double pm25;

        public static int CalculateAQI(double concentration)
        {
            double[] cLow = { 0, 12.1, 35.5};
            double[] cHigh = { 12, 35.4, 55.4 };
            int[] iLow = { 0, 51, 101 };
            int[] iHigh = { 50, 100, 150 };

            for (int i = 0; i < cLow.Length; i++)
            {
                if (concentration <= cHigh[i])
                {
                    return (int)(((iHigh[i] - iLow[i]) / (cHigh[i] - cLow[i])) * (concentration - cLow[i]) + iLow[i]);
                }
            }
            return 150;// max AQI if beyonf range
        }

        public static string ClassifyAQI(int AQI)
        {
            if (AQI <= 50)
            {
                return "Good";
            }
            if (AQI <= 100)
            {
                return "Moderate";
            }
            
            return "Unhealthy";
        }

        public void checkAQI()
        {
            Console.WriteLine("Enter the pollutants concentration (PM2.5): ");
            pm25 = Convert.ToDouble(Console.ReadLine());

            int AQI = CalculateAQI(pm25);
            string remark = ClassifyAQI(AQI);

            Console.WriteLine("AQI : "+AQI);
            Console.WriteLine("Remark : "+remark);
        }
    }
}
