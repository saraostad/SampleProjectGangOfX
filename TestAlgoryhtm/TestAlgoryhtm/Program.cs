using System;
using System.Collections.Generic;
using System.Linq;

namespace TestAlgoryhtm
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            #region Add Data To dic
            dic1.Add(1, "kiwi");
            dic1.Add(2, "pear");
            dic1.Add(3, "banana");
            dic1.Add(4, "melon");
            dic1.Add(5, "banana");
            dic1.Add(6, "melon");
            dic1.Add(7, "pineapple");
            dic1.Add(8, "cucumber");
            dic1.Add(9, "pineapple");
            dic1.Add(10, "cucumber");
            dic1.Add(11, "orange");
            dic1.Add(12, "apple");
            dic1.Add(13, "chery");
            dic1.Add(14, "pear");
            dic1.Add(15, "kiwi");
            dic1.Add(16, "kiwi");
            dic1.Add(17, "pear");
            dic1.Add(18, "banana");
            dic1.Add(19, "melon");
            dic1.Add(20, "banana");
            dic1.Add(21, "melon");
            dic1.Add(22, "pineapple");
            dic1.Add(23, "cucumber");
            dic1.Add(24, "pineapple");
            dic1.Add(25, "cucumber");
            dic1.Add(26, "orange");
            dic1.Add(27, "apple");
            dic1.Add(28, "chery");
            dic1.Add(29, "pear");
            dic1.Add(30, "kiwi");
            dic1.Add(31, "kiwi");
            dic1.Add(32, "pear");
            dic1.Add(33, "banana");
            dic1.Add(34, "melon");
            dic1.Add(35, "banana");
            dic1.Add(36, "melon");
            dic1.Add(37, "pineapple");
            dic1.Add(38, "cucumber");
            dic1.Add(39, "pineapple");
            dic1.Add(40, "cucumber");
            dic1.Add(41, "orange");
            dic1.Add(42, "apple");
            dic1.Add(43, "chery");
            dic1.Add(44, "pear");
            dic1.Add(45, "kiwi");
            dic1.Add(46, "cucumber");
            dic1.Add(47, "orange");
            dic1.Add(48, "apple");
            dic1.Add(49, "chery");
            dic1.Add(50, "pear");
            dic1.Add(51, "kiwi");
            dic1.Add(52, "melon");
            dic1.Add(53, "pineapple");
            dic1.Add(54, "cucumber");
            dic1.Add(55, "pineapple");
            dic1.Add(56, "cucumber");
            dic1.Add(57, "orange");
            dic1.Add(58, "apple");
            dic1.Add(59, "chery");
            dic1.Add(60, "pear");
            dic1.Add(61, "kiwi");
            dic1.Add(62, "kiwi");
            dic1.Add(63, "pear");
            dic1.Add(64, "banana");
            dic1.Add(65, "melon");
            dic1.Add(66, "banana");
            dic1.Add(67, "melon");
            dic1.Add(68, "pineapple");
            dic1.Add(69, "cucumber");
            dic1.Add(70, "cucumber");
            dic1.Add(71, "cucumber");
            dic1.Add(72, "orange");
            dic1.Add(73, "apple");
            dic1.Add(74, "pear");
            dic1.Add(75, "kiwi");
            dic1.Add(76, "cucumber");
            dic1.Add(77, "orange");
            dic1.Add(78, "apple");
            dic1.Add(79, "chery");
            dic1.Add(80, "pear");
            dic1.Add(81, "kiwi");
            dic1.Add(82, "melon");
            dic1.Add(83, "pineapple");
            dic1.Add(84, "cucumber");
            dic1.Add(85, "pineapple");
            dic1.Add(86, "cucumber");
            dic1.Add(87, "orange");
            dic1.Add(88, "apple");
            dic1.Add(89, "chery");
            dic1.Add(90, "pear");
            dic1.Add(91, "kiwi");
            dic1.Add(92, "kiwi");
            dic1.Add(93, "pear");
            dic1.Add(94, "banana");
            dic1.Add(95, "melon");
            dic1.Add(96, "banana");
            dic1.Add(97, "melon");
            dic1.Add(98, "pineapple");
            dic1.Add(99, "cucumber");
            dic1.Add(100, "cucumber");
            #endregion
            int minValue = 10; int maxValue = 1000;
            int number; string inputValue;
            while (true)
            {
                Console.Write($"Press A number Between {minValue} and {maxValue} :");
                inputValue = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(inputValue);
                    if (number < minValue || number > maxValue)
                    {
                        Console.WriteLine($"Input Number Not Valid");
                    }
                    else if (number >= minValue || number <= maxValue)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Input Value Not Valid");
                }
            }
            while (true)
            {
                List<string> listSplitNumbers = new List<string>();
                int sum = 0;
                for (int i = 0 ; i < inputValue.Length; i++)
                {
                    listSplitNumbers.Add(inputValue[i].ToString());
                    sum += Convert.ToInt32(listSplitNumbers[i]);
                }
                int newNumber = int.Parse(inputValue) - sum;
                Console.WriteLine("number is : " + newNumber.ToString());
                if (dic1.Where(q => q.Key.Equals(newNumber)).Any())
                {
                    Console.WriteLine(dic1.First(q => q.Key.Equals(newNumber)).Value);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    inputValue = newNumber.ToString();
                }
            }
        }
    }
}
