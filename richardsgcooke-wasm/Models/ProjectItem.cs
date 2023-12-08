using Microsoft.AspNetCore.Components;

public class ProjectItem
{
    public string Title { get; set; }
    public MarkupString Description { get; set; }
    public List<string>? ListThings { get; set; }
}