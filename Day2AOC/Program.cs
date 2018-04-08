using System;
using System.IO;
using System.Linq;

namespace Day2AOC
{
    class Program
    {
        static void Main(string[] args)
        {
            star1("input.txt");
            star2("input.txt");
            Console.ReadLine();
        }

        public static void star1(string fileName)
        {
            var lines = File.ReadLines(fileName);
            var checkSum = 0;

            foreach(var line in lines)
            {
                string[] lineArr = line.Split('\t');
                int[] parsedArr = new int[lineArr.Length];
                var count = 0;

                foreach(var num in lineArr)
                {
                    var parsedNum = 0;
                    Int32.TryParse(num, out parsedNum);
                    parsedArr[count] = parsedNum;
                    count++;
                }

                Array.Sort(parsedArr, (x, y) => y.CompareTo(x));

                var highestNumber = parsedArr[0];
                var lowestNumber = parsedArr[parsedArr.Length - 1];

                checkSum += (highestNumber - lowestNumber);
            }

            Console.WriteLine(checkSum);
        }

        public static void star2(string fileName)
        {
            var lines = File.ReadLines(fileName);
            var checkSum = 0;

            foreach (var line in lines)
            {
                string[] lineArr = line.Split('\t');
                int[] parsedArr = new int[lineArr.Length];
                var count = 0;

                foreach (var num in lineArr)
                {
                    var parsedNum = 0;
                    Int32.TryParse(num, out parsedNum);
                    parsedArr[count] = parsedNum;
                    count++;
                }

                for(var i = 0; i < parsedArr.Length; i++)
                {
                    for(var j = 0; j < parsedArr.Length; j++)
                    {
                        var divisible = parsedArr[i] % parsedArr[j];

                        if (divisible == 0 && i != j)
                            checkSum += (parsedArr[i] / parsedArr[j]);
                    }
                }

            }

            Console.WriteLine(checkSum);
        }
    }
}
