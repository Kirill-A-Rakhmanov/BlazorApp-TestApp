using System;

namespace BlazorApp.App.Shared.Model;

public class FileInfo
{
    public required string Cover { get; set; }
    public required string Name { get; set; }
    public decimal Weight { get; set; }
}
