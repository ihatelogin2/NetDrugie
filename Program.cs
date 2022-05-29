using System;
namespace ConsoleApp28052022
{
    public class PESELWalidator
    {
        public static void Main(string[] args)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            Console.WriteLine("Type any pesel:  ");

            String pesel2 = Console.ReadLine();
            Console.WriteLine(PESELValidator(pesel2));
            Console.WriteLine(Plec(pesel2));
            Console.WriteLine(SumaKontrolna(pesel2, weights));           

        }
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel = { 0, 0, 2, 1, 2, 3, 0, 6, 1, 7, 0 };

        public static bool PESELValidator(String pesel)
        {
            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            bool result = false;
            if (pesel.Length == 11)
            {
                int controlSum = SumaKontrolna(pesel, weights);
                int controlNum = controlSum % 10;
                controlNum = 10 - controlNum;
                if (controlNum == 10)
                {
                    controlNum = 0;
                }
                int lastDigit = int.Parse(pesel[pesel.Length - 1].ToString());
                result = controlNum == lastDigit;
            }
            return result;

        }



        private static int SumaKontrolna(string pesel, int[] weights)
        {
            int offset = 0;
            int controlSum = 0;
            for (int i = 0; i < pesel.Length - 1; i++)
            {
                controlSum += weights[i + offset] * int.Parse(pesel[i].ToString());
            }
            return controlSum;
        }

        public String DataUrodzenia(string pesel)
        {
            return pesel;
        }

        private static String Plec(string pesel)
        {
            if (pesel[9] % 2 == 1)
            {
                return "Mezczyzna";
            }
            else
            {
                return "Kobieta";
            }

        }


        public Boolean SprawdzPesel()
        {
            return false;
        }

    }
}
