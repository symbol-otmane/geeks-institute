using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public string Name { get; }
    public int Age { get; }

    public List<User> Friends { get; }
    public List<Post> Posts { get; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
        Friends = new List<User>();
        Posts = new List<Post>();
    }

    public void AddFriend(User user)
    {
        if (user == this)
        {
            Console.WriteLine("You cannot add yourself as a friend.");
            return;
        }

        if (Friends.Contains(user))
        {
            Console.WriteLine("This user is already on your friends list.");
            return;
        }

        Friends.Add(user);
        Console.WriteLine($"{Name} added {user.Name} to the friends list.");
    }

    public void RemoveFriend(User user)
    {
        if (!Friends.Contains(user))
        {
            Console.WriteLine("This user is not in your friends list.");
            return;
        }

        Friends.Remove(user);
        Console.WriteLine($"{Name} has removed {user.Name} from the friends list.");
    }

    public void ShowFeed()
    {
        Console.WriteLine($"\n===== {Name}'s Feed =====\n");

        var allPosts = new List<Post>();

        foreach (var friend in Friends)
        {
            allPosts.AddRange(friend.Posts);
        }

        if (allPosts.Count == 0)
        {
            Console.WriteLine("No posts available in your feed.");
            return;
        }

        foreach (var post in allPosts.OrderByDescending(p => p.Timestamp))
        {
            Console.WriteLine($"{post.Author.Name} posted: \"{post.Content}\" (Likes: {post.Likes.Count})");

            foreach (var comment in post.Comments)
            {
                Console.WriteLine($"  - {comment.Author.Name} commented: \"{comment.Content}\" (Likes: {comment.Likes.Count})");
            }

            Console.WriteLine();
        }
    }
}
