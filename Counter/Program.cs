namespace Counter
{

    class Counter
    {
        private int value;
        public void SetValue(int value)
        {

            this.value = value;

        }
        public void Increment(int value)
        {

            this.value = value + 1;

        }
        public void Decrement(int value)
        {

            this.value = value - 1;

        }
        public void Reset()
        {

            this.value = -1;

        }
        public int GetValue()
        {

            return value;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Increment(1);
            Console.WriteLine(counter.GetValue());
            counter.Reset();
            Console.WriteLine(counter.GetValue());
            counter.SetValue(5);
            Console.WriteLine(counter.GetValue());

        }
    }
}