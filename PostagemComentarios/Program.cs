using PostagemComentarios.Entities;
using System;


namespace PostagemComentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(
                DateTime.Parse("2018/06/24 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful contry!",
                12
                );

            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            Comment comment1 = new Comment("Have a nice trip");
            Comment comment2 = new Comment("Wow that's awsome!");
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good Night");
            Comment comment4 = new Comment("May the force be with you");
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
