using System;

namespace BlazorApp.App.Shared.Model;

public class MessageItem
{
    public required UserInfo User { get; set; }
    public string? Text { get; set; }
    public DateTime DateTime { get; set; }

    public FileInfo? File { get; set; }
}
