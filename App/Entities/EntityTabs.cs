using System;
using System.Runtime.CompilerServices;
using BlazorApp.Shared.Model;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace BlazorApp.Entities;

public class EntityTabs
{
    private readonly TabItem[] tabs =
    [
        new() { Id = 1, Name = "Основная информация" },
        new()
        {
            Id = 2,
            Name = "Задачи",
            Notifications = 1,
        },
        new() { Id = 3, Name = "Собеседования" },
        new() { Id = 4, Name = "Чат" },
        new() { Id = 5, Name = "Комментарии" },
        new() { Id = 6, Name = "История изменений" },
    ];

    public TabItem[] GetTabs() => tabs;
}
