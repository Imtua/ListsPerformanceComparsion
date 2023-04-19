using System.Diagnostics;

namespace ListsPerformanceComparsion
{
    internal class ReadFileTesting
    {
        public static void TestToList()
        {
            var timer = new Stopwatch();
            timer.Start();
            ReadFile.ToList();
            timer.Stop();
            Console.WriteLine("Время работы ToList(): {0} мс",
                timer.ElapsedMilliseconds);
        }

        public static void TestToLinkedList()
        {
            var timer = new Stopwatch();
            timer.Start();
            ReadFile.ToLinkedList();
            timer.Stop();
            Console.WriteLine("ToLinkedList(): {0} мс",
                timer.ElapsedMilliseconds);
        }
    }
}
