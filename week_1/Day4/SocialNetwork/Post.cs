using System;
using System.Collections.Generic;

public class Post
{
    public User Author { get; }
    public string Content { get; }
    public List<Comment> Comments { get; }
    public List<User> Likes { get; }
    public DateTime Timestamp { get; }

    public Post(User author, string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new Exception("A post cannot be empty!");

        Author = author;
        Content = content;
        Comments = new List<Comment>();
        Likes = new List<User>();
        Timestamp = DateTime.Now;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine("This user has already liked this post.");
            return;
        }

        Likes.Add(user);
    }
}
