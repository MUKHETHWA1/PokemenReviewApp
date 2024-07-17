namespace PokemenReviewApp.models
{
    public class Owner
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Gym { get; set; }
        //one to many relation
        public Country Country { get; set; }
        //many to many relation
        public ICollection<PokemonOwner> PokemonOwners { get; set; }

    }
}
