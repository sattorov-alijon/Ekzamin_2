namespace Tasc8;

public class Post
{
public string Title { get; set; }
public string Description { get; set; }
public int LikeCount { get; set; }
public List<string> Comments { get; set; }
public bool IsPublished { get; set; }

public string Publish()
{
    IsPublished=true;
    return $"The post is published.";
}

public void Like()
{
    LikeCount++;
}

public void Comment(string message)
{
    Comments.Add(message);
}




}
