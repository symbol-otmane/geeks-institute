using System;
using System.Collections.Generic;

public class Comment
{
    public User Author { get; }
    public string Content { get; }
    public List<User> Likes { get; }

    public Comment(User author, string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new Exception("A comment cannot be empty!");

        Author = author;
        Content = content;
        Likes = new List<User>();
    }

    public void AddLike(User user)
    {
        if (Likes.Contains(user))
        {
            Console.WriteLine("This user has already liked the comment.");
            return;
        }

        Likes.Add(user);
    }
}
