namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Interval i1 = new(DateTime.Now, DateTime.Now.AddDays(1));
            Interval i2 = new(DateTime.Now.AddDays(2), DateTime.Now.AddDays(10));
            if (i1.CompareTo(i2) == 0)
            {
                Console.WriteLine("Lige store intervaller");
            }
            else if (i1.CompareTo(i2) > 0)
            {
                Console.WriteLine("i1 er større end i2");
            }
            else
            {
                Console.WriteLine("i2 er større end i1");
            }
        }
    }

    public class Interval : IComparable<Interval>
    {
        private DateTime start;
        private DateTime end;

        public Interval(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public int CompareTo(Interval other)
        {
            TimeSpan thisTimeSpan = end - start;
            TimeSpan otherTimeSpan = other.end - other.start;
            if (thisTimeSpan.Ticks < otherTimeSpan.Ticks)
            {
                return -1;
            }
            else if (thisTimeSpan.Ticks > otherTimeSpan.Ticks)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
    }
}