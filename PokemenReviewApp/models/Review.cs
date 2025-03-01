﻿namespace PokemenReviewApp.models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        //one to many relation
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
