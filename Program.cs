using System;

/* 14
Дана последовательность натуральных чисел. 
Определить, есть ли в последовательности хотя бы одна n-ка одинаковых “соседних” чисел 
(n и элементы последовательности вводятся с клавиатуры). 
В случае положительного ответа определить порядковые номера чисел первой из таких пар.
*/

namespace FirstLAB2ex
{
    public class Logic
    {
        public static int numberOfRows() //проверка правильности ввода количесвта одинаковых символов
        {
            int amount;
            while (!int.TryParse(Console.ReadLine(), out amount) || amount < 1)
            {
                Console.WriteLine("Введите число больше 1: ");
            }
            return amount;
        }

        public static string findSimilarSymbols(String line, int amount)
        {
            String ans = "Прогармма не нашла нужных символов";
            int similar;
            int startPosition = 0;
            for (int i = 0; i < line.Length - 1; i++)
            {
                similar = 1;
                startPosition = i;
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[i] == line[j])
                    {
                        similar++;
                    }
                    else break;
                }

                if (isAnsver(similar, amount))
                {
                    ans = "Программа нашла символы с " + (startPosition + 1) + " по " + (startPosition + similar);
                    break;
                }

            }
            return ans;
        }

        public static bool isAnsver(int similar, int amount)
        {
            if (similar == amount)
            {
                return true;
            }
            else return false;
        }
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов, которые должны быть подряд в строке: ");

            int amount = Logic.numberOfRows();

            Console.WriteLine("Введите строку символов: ");
            string line = Console.ReadLine();

            Console.WriteLine(Logic.findSimilarSymbols(line, amount));
        }
    }
}
