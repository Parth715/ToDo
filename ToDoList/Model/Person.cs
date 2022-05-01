namespace ToDoList.Model
{
    public class Person
    {
        public Person(){ }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
