
namespace CollectionLinqStreamDemo
{
    internal class TaskItem(string title, DateTime created, bool isDone, int priority)
    {
        public string Title { get; set; } = title;
        public DateTime Created { get; set; } = created;
        public bool IsDone { get; set; } = isDone;
        public int Priority { get; set; } = priority;

        public override string ToString()
        {
            return $"{Title} (Erstellt: {Created}, Erledigt: {IsDone}, Priorität: {Priority})";
        }
    }
}
