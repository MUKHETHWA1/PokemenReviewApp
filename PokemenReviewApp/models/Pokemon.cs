namespace PokemenReviewApp.models
{
    public class Pokemon
    {
        //decleration
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        //one to many relation
        public ICollection<Review> Reviews { get; set; }
        //mant to many relation
        public ICollection<PokemonOwner> PokemonOwners { get; set; }
        public ICollection<PokemonCategory> PokemonCategories { get; set; }


    }
}
