namespace MyApp.Shared.Models
{
    
    public class Rajongok
    {
       
        public string Name { get; set; } = string.Empty;

       
        public int Age{ get; set; }

      
        public string Sportag { get; set; } = string.Empty;

        public Rajongok() { }

        public Rajongok(string name, int age, string sportag)
        {
            Name = name;
            Age = age;
            Sportag = sportag;
        }

        public override string ToString() => $"{Name} - {Age} – {Sportag}";
    }
}
