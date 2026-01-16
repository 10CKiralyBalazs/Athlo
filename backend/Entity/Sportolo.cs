namespace MyApp.Backend.Entity
{
    public class Sportolo
    {
        public string Name { get; set; } = string.Empty;


        public int Age { get; set; }


        public string Sportag { get; set; } = string.Empty;
        public string Egyesulet { get; set; } = string.Empty;




        public Sportolo() { }

        public Sportolo(string name, int age, string sportag, string egyesulet)
        {
            Name = name;
            Age = age;
            Sportag = sportag;
            Egyesulet = egyesulet;
        }

        public override string ToString() => $"{Name} ({Age}) – {Sportag} - {Egyesulet}";
    }
}
