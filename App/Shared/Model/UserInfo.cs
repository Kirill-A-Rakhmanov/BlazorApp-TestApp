using System;

namespace BlazorApp.App.Shared.Model;

public class UserInfo
{
    public required string Name { get; set; }
    public required string Occupation { get; set; }
    public string? Image { get; set; }
}
