namespace Exercise_1.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Defense { get; set; }
        public int Attaque { get; set; }
        public int SpecialAttaque { get; set; }
        public int SpecialDefense { get; set; }
        public int Vitesse { get; set; }
        public int Generation { get; set; }
        public bool Legendaire { get; set; }
        public string Description { get; set; }
    }
}
