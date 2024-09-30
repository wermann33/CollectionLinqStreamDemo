namespace CollectionLinqStreamDemo
{
    // FileHandler Klasse: Zum Speichern und Laden von Tasks in/aus einer Datei.
    internal class FileHandler
    {
        // Speichere die Task-Liste in einer Textdatei (Einfaches Datei-Handling)
        public static void SaveToFile(string filePath, List<TaskItem> tasks)
        {
            using StreamWriter writer = new(filePath);
            foreach (var task in tasks)
            {
                writer.WriteLine($"{task.Title}|{task.Created}|{task.IsDone}|{task.Priority}");
            }
        }

        // Lese die Task-Liste aus einer Textdatei (Einfaches Datei-Handling)
        public static List<TaskItem> LoadFromFile(string filePath)
        {
            var tasks = new List<TaskItem>();

            using StreamReader reader = new(filePath);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 4)
                {
                    var task = new TaskItem(parts[0], DateTime.Parse(parts[1]), bool.Parse(parts[2]), int.Parse(parts[3]));
                    tasks.Add(task);
                }
            }

            return tasks;
        }
    }
}
