namespace PokemenReviewApp.models
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //one to many relation
        public ICollection<Review> Reviews { get; set; }
    }
}
