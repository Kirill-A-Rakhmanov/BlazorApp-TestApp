using System;

namespace BlazorApp.Shared.Model;

public class MenuItem
{
    public int Id { get; set; }

    public required string IconName { get; set; }

    public required string Name { get; set; }

    public int? NotificationsNumber { get; set; }

    public bool SubElements { get; set; }
    public required string PageLink { get; set; }
}
