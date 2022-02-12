using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreWorkMidTerm
{
    public static class PixelCal
    {
        public static double diagnolPixels = 0.0;
        public static double ppi = 0.0;
        public static double dotPitch = 0.0;
        public static void ppiCalculation(int height, int width, double diagnol)
        {
            
            long squareHeight = (long)Math.Pow(height, 2);
            long squareWidth = (long)Math.Pow(width, 2);
            

            diagnolPixels = Math.Round(Math.Sqrt(squareHeight + squareWidth), 2);
            ppi = Math.Round((diagnolPixels / diagnol), 2);
            dotPitch = Math.Round(((diagnol / diagnolPixels) * 25.4), 4);

            Console.WriteLine($"PPI = {ppi}");
            Console.WriteLine($"Diagnol (Pixels) = {diagnolPixels}");
            Console.WriteLine($"Dot pitch = {dotPitch}");
        }
    }
}
