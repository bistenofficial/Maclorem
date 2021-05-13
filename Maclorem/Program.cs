using System;

namespace lab_formulas
{
    class Program
    {
        static double delX = 0.001;
        static int n = 10;

        static double getMaclorem()
        {
            double answer = 0;
            return answer;
        }

        static double[] getArray()
        {
            double[] peremennaya = new double[n + 1];
            for (int i = 0; i <= n; i++)
            {
                //Math.Round(1 / (1 + Math.Pow((delX * i), 2)), 5);
                //Math.Round(1/(delX * i+1), 5);
                peremennaya[i] = Math.Round(Math.Cos(Math.Pow(delX * i, 2)), 4);
            }
            return peremennaya;
        }
        static void Main(string[] args)
        {
            double[] arr = getArray();
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            double answer = Math.Round((delX / 3) * (arr[0] + arr[10] + 4 * (arr[1] + arr[3] + arr[5] + arr[7] + arr[9]) + 2 * (arr[2] + arr[4] + arr[6] + arr[8])), 4);
            Console.WriteLine($"({delX} / 3)*({arr[0]} + {arr[10]} + 4*({arr[1]} + {arr[3]} + {arr[5]} + {arr[7]} + {arr[9]})+2*({arr[2]} + {arr[4]} + {arr[6]} + {arr[8]}));");
            Console.WriteLine($"Anaswer is {answer}");
        }
    }
}