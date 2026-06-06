namespace Collection4
{

    //Задача: Эмулируйте очередь покупателей(Queue<string>).
    //Создайте цикл, где в очередь добавляются новые клиенты(имена),
    //а затем в каждом шаге цикла первый покупатель обслуживается и удаляется
    //из очереди.
    internal class Program
    {
        public static void Main()
        {
            // 1. Создаем очередь покупателей
            Queue<string> customersQueue = new Queue<string>();

            // 2. Добавляем новых клиентов в очередь (Enqueue)
            customersQueue.Enqueue("Алексей");
            customersQueue.Enqueue("Мария");
            customersQueue.Enqueue("Дмитрий");
            customersQueue.Enqueue("Елена");

            Console.WriteLine($"Всего клиентов в очереди: {customersQueue.Count}\n");

            // 3. Цикл обработки: пока очередь не пуста
            while (customersQueue.Count > 0)
            {
                // Peek() позволяет посмотреть, кто первый на очереди, не удаляя его
                string currentCustomer = customersQueue.Peek();
                Console.WriteLine($"Обслуживается: {currentCustomer}");

                // Dequeuе() удаляет и возвращает первого покупателя из очереди
                string servedCustomer = customersQueue.Dequeue();
                Console.WriteLine($"Клиент {servedCustomer} покинул очередь.\n");
            }

            Console.WriteLine("Очередь пуста. Все клиенты обслужены!");
        }
    }
}
