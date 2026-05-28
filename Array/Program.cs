namespace Array
{
    internal class Program
    {
        public static void ArrayResize<T>(ref T[] array, int newLenght) //дженерик <T> позволяет вместо него передавать массив любого типа данных
        {
            T[] newArray = new T[newLenght];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
                newArray[i] = array[i];

            array = newArray;
        }
        static void InsertItemByIndex(ref int[] array, int newItem, int index)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            newArray[index] = newItem;

            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }

        static void RemoveItemByIndex(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }
        static void Main()
        {
            int[] myArray = { 1, 2, 3, 5, 7 };

            //ArrayResize(ref myArray, 3);

            // InsertItemByIndex(ref myArray, 1, 2);

            RemoveItemByIndex(ref myArray, 4);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
