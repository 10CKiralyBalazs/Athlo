namespace MyApp.Backend.Entity
{
    public class Edzok
    {
        public string Name { get; set; } = string.Empty;


        public int Age { get; set; }


        public string Egyesulet { get; set; } = string.Empty;

        public string Sportoloi { get; set; } = string.Empty;

        public Edzok() { }

        public Edzok(string name, int age, string egyesulet, string sportoloi)
        {
            Name = name;
            Age = age;
            Egyesulet = egyesulet;
            Sportoloi = sportoloi;
        }

        public override string ToString() => $"{Name} – {Age} - {Egyesulet} - {Sportoloi})";
    }
}
