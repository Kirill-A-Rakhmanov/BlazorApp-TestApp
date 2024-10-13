using System;
using BlazorApp.App.Shared.Model;

namespace BlazorApp.App.Entities;

public class EntityComments
{
    private readonly List<MessageItem> items =
    [
        new()
        {
            User = new()
            {
                Name = "Мария Красельникова",
                Occupation = "HR-Менеджер",
                Image = "avatar",
            },
            Text =
                "Добавьте комментарий о наличии корпоративного ДМС, предоставления рабочего оборудования и официального трудоустройства.",
            DateTime = new DateTime(2024, 10, 13, 15, 30, 0),
        },
        new()
        {
            User = new()
            {
                Name = "Сергей Валентинов",
                Occupation = "Кандидат",
                Image = "avatar2",
            },
            File = new()
            {
                Name =
                    "Очень-длинный-длинный-длинный-длинный-длинный-длинный-длинный-длинный-длинный файл.dox",
                Weight = 4.4M,
                Cover = "file",
            },
            DateTime = new DateTime(2024, 10, 13, 15, 45, 0),
        },
        new()
        {
            User = new() { Name = "Валерий Филатов", Occupation = "Генеральный директор" },
            Text =
                "Нам срочно нужен разработчик в штат, чтобы быстрее внедрять новые технологии и улучшать наши рабочие процессы. Это поможет нам быть более эффективными и конкурентоспособными на рынке",
            DateTime = new DateTime(2024, 10, 13, 16, 0, 0),
        },
    ];

    public MessageItem[] GetMessages() => [.. items];

    public void AddComment(MessageItem newMessage)
    {
        items.Add(newMessage);
    }
}
