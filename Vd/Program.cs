public class Program
{
    public static void Main(string[] args)
    {
        
        Student std = new Student();
        std.ShowInfo();
        
    }

    public class Student
    {
        private int id;
        private string name;
        public int age;

        public int Id
        {
            get
            {
                return id;
            }
            private set 
            {
                id = value; 
            }
        }

        public int Class { get; set; }
        
        public void ShowInfo()
        {
            Id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Name: {name} - age: {age} - Id: {Id} - class: {Class}");
        }
        public void SetName(string name)
        {
            this.name = name;
        }
    }
}