namespace ClassSamples
{
    public static class StatelessCalculator
    {
        public static int Sum(int num01,int num02)
        {
            return num01 + num02;
        }

        public static int Sub(int num01, int num02) {
            return num01 - num02;
        }
    }

    public class Car
    {
        public const int MaxValue = 100;
        public static string Description =>
            "This is my Car class";

        public static int InstanceCount
        {
            get;
            private set;
        }
        static Car()
        {
            InstanceCount = 98;
        }
        public Car()
        {
            if(InstanceCount > MaxValue)
            {
                throw new Exception("Invalid new Instance");
            }
            InstanceCount += 1;
        }

        public int Color { get; set; }

        public int Speed { get;private set; }


        public void AddSpeed(int value)
        {
            string localDescription = Description;
            Speed += value;
        }

        public static void Print()
        {
            Console.WriteLine(Description);
            Console.WriteLine($"Car speed is:");
        }

    }
}
