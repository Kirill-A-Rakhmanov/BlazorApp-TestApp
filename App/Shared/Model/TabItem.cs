using System;

namespace BlazorApp.Shared.Model;

public class TabItem
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int? Notifications { get; set; }
}
