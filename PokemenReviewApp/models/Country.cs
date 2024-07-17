namespace PokemenReviewApp.models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //one to many relation
        public ICollection<Owner> Owners { get; set; }   
    }
}
