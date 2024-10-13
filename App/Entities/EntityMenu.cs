using System;
using BlazorApp.Shared.Model;

namespace BlazorApp.Entities;

public class EntityMenu
{
    private readonly MenuItem[] items =
    [
        new()
        {
            Id = 1,
            IconName = "dashboard",
            Name = "Рабочий стол",
            SubElements = false,
            PageLink = "",
        },
        new()
        {
            Id = 2,
            IconName = "mail",
            Name = "Заявки",
            NotificationsNumber = 1,
            SubElements = false,
            PageLink = "applications",
        },
        new()
        {
            Id = 3,
            IconName = "member-search",
            Name = "План найма",
            SubElements = false,
            PageLink = "recruitment-plan",
        },
        new()
        {
            Id = 4,
            IconName = "job",
            Name = "Вакансии",
            NotificationsNumber = 1,
            SubElements = false,
            PageLink = "vacancies",
        },
        new()
        {
            Id = 5,
            IconName = "candidate",
            Name = "Кандидаты",
            NotificationsNumber = 1,
            SubElements = true,
            PageLink = "candidates",
        },
        new()
        {
            Id = 6,
            IconName = "calendar",
            Name = "Календарь",
            SubElements = false,
            PageLink = "calendar",
        },
        new()
        {
            Id = 7,
            IconName = "chat",
            Name = "Чат",
            NotificationsNumber = 1,
            SubElements = true,
            PageLink = "chat",
        },
        new()
        {
            Id = 8,
            IconName = "study",
            Name = "Обучение",
            SubElements = false,
            PageLink = "study",
        },
        new()
        {
            Id = 9,
            IconName = "star",
            Name = "Тарифы и оплата",
            SubElements = false,
            PageLink = "payment-plans",
        },
        new()
        {
            Id = 10,
            IconName = "settings",
            Name = "Настройки",
            SubElements = false,
            PageLink = "settings",
        },
    ];

    public MenuItem[] GetMenuItems() => items;
}
