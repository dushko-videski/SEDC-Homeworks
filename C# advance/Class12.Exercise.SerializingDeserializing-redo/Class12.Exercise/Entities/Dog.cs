namespace Class12.Exercise.Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }


        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }


    }
}
