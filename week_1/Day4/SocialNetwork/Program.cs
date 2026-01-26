using System;

class Program
{
    static void Main()
    {
        User MrFall = new User("MrFall", 25);
        User Symbol = new User("Symbol", 30);
        User Yassine = new User("Yassine", 22);

        MrFall.AddFriend(Symbol);
        Symbol.AddFriend(Yassine);

        Post post1 = new Post(MrFall, "Hello everyone!");
        MrFall.Posts.Add(post1);

        Comment comment1 = new Comment(Symbol, "Nice post!");
        post1.AddComment(comment1);

        post1.AddLike(Symbol);
        comment1.AddLike(Yassine);

        Symbol.ShowFeed();

        Console.WriteLine("\nDone! Program finished.");
    }
}
