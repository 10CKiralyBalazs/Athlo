namespace MyApp.Shared.Models
{
    /// <summary>
    /// Diák adatait tároló osztály.
    /// </summary>
    public class Sportolo
    {
        /// <summary>
        /// A diák neve.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// A diák életkora.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Az osztály, amelybe a diák jár.
        /// </summary>
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
