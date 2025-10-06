namespace CollectionLinqStreamDemo;

internal class Program
{
    static void Main()
    {
        static void PrintTasks(IEnumerable<TaskItem> tasks)
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task.ToString());
            }

            Console.WriteLine();
        }

        var task1 = new TaskItem("C# lernen", DateTime.Now, false, 1);
        var task2 = new TaskItem(".NET lernen", DateTime.Now, false, 3);
        var task3 = new TaskItem("Collections lernen", DateTime.Now, true, 2);



        // 1. List<T>: Reihenfolge bleibt, wie hinzugefügt, Zugriff über Index
        var itemList = new List<TaskItem>
        {
            task1,
            task2,
            task3
        };
        //Console.WriteLine("Print List:");
        //PrintTasks(itemList);


        // 2. Dictionary<TKey, TValue>: Schlüssel-Wert-Speicher, schneller Zugriff über Schlüssel
        //var itemDictionary = new Dictionary<int, TaskItem>
        //{
        //    { 1, task1 },
        //    { 2, task2 },
        //    { 3, task3 }
        //};
        //Console.WriteLine("Print Dictionary:");
        //foreach (var kvp in itemDictionary)
        //{
        //    Console.WriteLine($"Key: {kvp.Key}, Task: {kvp.ToString()}");
        //}
        //Console.WriteLine();


        // 3. Stack<T>: Last In, First Out (LIFO), wie ein Stapel Papier
        //var itemStack = new Stack<TaskItem>();
        //itemStack.Push(task1);
        //itemStack.Push(task2);
        //itemStack.Push(task3);
        //Console.WriteLine("Print Stack:");
        //PrintTasks(itemStack);
        //itemStack.Pop(); // Nimm das oberste Element vom Stack (LIFO)
        //Console.WriteLine("Print Stack after Pop():");
        //PrintTasks(itemStack);

        // 4. Queue<T>: First In, First Out (FIFO), wie eine Warteschlange
        //var itemQueue = new Queue<TaskItem>();
        //itemQueue.Enqueue(task1);
        //itemQueue.Enqueue(task2);
        //itemQueue.Enqueue(task3);
        //Console.WriteLine("Print Queue:");
        //PrintTasks(itemQueue);
        //itemQueue.Dequeue(); // Nimm das erste Element aus der Warteschlange (FIFO)
        //Console.WriteLine("Print Queue after Dequeue():");
        //PrintTasks(itemQueue);

        // File-Handling Beispiel
        //Console.WriteLine("\nSpeichere Aufgaben in Datei...");
        //FileHandler.SaveToFile("tasks.txt", itemList);

        //Console.WriteLine("\nLade Aufgaben aus Datei:");
        //var loadedTasks = FileHandler.LoadFromFile("tasks.txt");
        //loadedTasks.ForEach(Console.WriteLine);

        // LINQ-Beispiele mit der List<T>:
        Console.WriteLine("\nLINQ-Beispiele mit List<T>:");
        //var notDoneTasks = itemList.Where(t => !t.IsDone);  // Nur nicht erledigte Aufgaben anzeigen
        //Console.WriteLine("\nNicht erledigte Aufgaben:");
        //notDoneTasks.ToList().ForEach(Console.WriteLine);

        var sortedByPriority = itemList.OrderBy(t => t.Priority);  // Nach Priorität sortieren
        Console.WriteLine("\nNach Priorität sortierte Aufgaben:");
        sortedByPriority.ToList().ForEach(Console.WriteLine);
    }
}