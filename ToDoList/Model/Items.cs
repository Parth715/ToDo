namespace ToDoList.Model
{
    public class Item
    {
        public Item() { }
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public Boolean Completed { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        
    }
}
