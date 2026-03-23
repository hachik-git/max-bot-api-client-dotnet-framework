using MAX.Bot.Extensions;
using MAX.Bot.Interfaces;
using MAX.Bot.Interfaces.Models.Request;
using MAX.Bot.Interfaces.Models.Request.Message;
using MAX.Bot.Interfaces.Models.Request.Message.Attachment;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

internal class Program
{
    static async Task Main(string[] args)
    {
        const string C_BOT_API = "YOUR_BOT_TOKEN";
        const long C_TEST_CHAT_ID = -70581633278133;
        const long C_TEST_USER_ID = 12345678;
        const string C_TEST_MEDIA_FILE_NAME = @"PATH_TO_FILE";

        var services = new ServiceCollection();
        services.AddMaxBotClient(C_BOT_API, 30);

        var serviceProvider = services.BuildServiceProvider();
        var maxApiClient = serviceProvider.GetRequiredService<IMaxBotClient>();

        Console.WriteLine("Вызываем GetMeAsync...");
        var me = await maxApiClient.GetMeAsync();
        Console.WriteLine($"Успех! Бот: {me.FirstName} (ID: {me.Id})");

        Console.WriteLine("Вызываем SendMessageAsync...");
        await maxApiClient.SendMessageAsync(new SendMessageRequest()
        {
            //ChatId = C_TEST_CHAT_ID,
            UserId = C_TEST_USER_ID,
            Text = "Отправка сообщения",
            Format = MessageFormat.Markdown,
        });

        Console.WriteLine("Вызываем SendMessageAsync-Attachment-InlineKeyboardPayload...");
        await maxApiClient.SendMessageAsync(new SendMessageRequest()
        {
            //ChatId = C_TEST_CHAT_ID,
            UserId = C_TEST_USER_ID,
            Text = "Отправка сообщения с клавиатурой и изображением",
            Format = MessageFormat.Markdown,
            Attachments = new List<Attachment>
            {
                new InlineKeyboardAttachment
                {
                    Payload = new InlineKeyboardPayload()
                    {
                        Buttons = new List<List<Button>>()
                        {
                            // --- Ряд 1: Две кнопки ---
                            new List<Button>
                            {
                                new LinkButton
                                {
                                    Text = "Открыть сайт",
                                    Url = "https://saasoft.ru"
                                },
                                new CallbackButton
                                {
                                    Text = "Подтвердить",
                                    Payload = "confirm_action"
                                }
                            },
                            // --- Ряд 2: Одна большая кнопка ---
                            new List<Button>
                            {
                                new RequestGeoButton
                                {
                                    Text = "Отправить геолокацию",
                                    Quick = true
                                }
                            },
                            // --- Ряд 3: Одна большая кнопка ---
                            new List<Button>
                            {
                                new MessageButton()
                                {
                                    Text = "Отправить текст",
                                }
                            }
                        }
                    }
                },
                new ImageAttachment
                {
                    Payload = maxApiClient.CreateMediaAttachmentAsync<ImagePayload>(File.ReadAllBytes(C_TEST_MEDIA_FILE_NAME), Path.GetFileName(C_TEST_MEDIA_FILE_NAME)).GetAwaiter().GetResult()
                }
            }
        });

        Console.WriteLine("Вызываем GetMessagesAsync...");
        var response = await maxApiClient.GetMessagesAsync(new GetMessagesRequest()
        {
            ChatId = C_TEST_CHAT_ID,
        });
        Console.WriteLine($"Получено {response?.Messages?.Length} сообщений:");

        if (response?.Messages?.Length > 0)
        {
            Console.WriteLine("Вызываем GetMessageByIdAsync...");
            var responseById = await maxApiClient.GetMessageByIdAsync(response?.Messages?.Last().Body.Mid);
            Console.WriteLine($"Получено {responseById?.Body.Text}:");

            Console.WriteLine("Вызываем EditMessageByIdAsync...");
            var responseEdit = await maxApiClient.EditMessageByIdAsync(response?.Messages?.Last().Body.Mid, new SendMessageRequest()
            {
                Text = "Изменил ТЕКСТ !!!",
                Format = MessageFormat.Markdown,
            });
            Console.WriteLine($"Изменено {responseEdit?.Success}:");

            Console.WriteLine("Вызываем DeleteMessageByIdAsync...");
            var responseDelete = await maxApiClient.DeleteMessageByIdAsync(response?.Messages?.First().Body.Mid);
            Console.WriteLine($"Удалено {responseDelete?.Success}:");
        }
        Console.WriteLine("Вызываем GetChatsAsync...");
        var responseChats = await maxApiClient.GetChatsAsync(new GetChatsRequest()
        {
            Count = 1,
            Marker = null,
        });
        Console.WriteLine($"Получено {responseChats?.Chats?.Length} чатов:");

        Console.WriteLine("Вызываем GetChatMembersAsync...");
        var responseChatMembers = await maxApiClient.GetChatMembersAsync(new GetChatMembersRequest()
        {
            ChatId = C_TEST_CHAT_ID,
        });
        Console.WriteLine($"Получено {responseChatMembers?.Members?.Length} пользователей:");

        Console.WriteLine("Вызываем AddChatMemberAsync...");
        var isAdded = await maxApiClient.AddChatMemberAsync(new AddChatMemberRequest()
        {
            ChatId = C_TEST_CHAT_ID,
            UserIds = new long[] { C_TEST_USER_ID },
        });

        if (isAdded != null && isAdded.Success)
        {
            Console.WriteLine("Пользователь успешно добавлен в чат");
        }

        Console.WriteLine("Вызываем DeleteChatMemberAsync...");
        var isDeleted = await maxApiClient.DeleteChatMemberAsync(new DeleteChatMemberRequest()
        {
            ChatId = C_TEST_CHAT_ID,
            UserId = C_TEST_USER_ID,
        });

        if (isDeleted != null && isDeleted.Success)
        {
            Console.WriteLine("Пользователь успешно удален из чата");
        }

        Console.WriteLine("Вызываем GetMessageByIdAsync...");
        var responseMessage = await maxApiClient.GetMessageByIdAsync("mid.ffffbfce6ed21f4b019c2841060d67ac");
        Console.WriteLine($"Получено сообщение по ID: {responseMessage?.Body?.Text}");

        Console.WriteLine("Вызываем GetUpdatesAsync...");
        var responseUpdates = await maxApiClient.GetUpdatesAsync(new GetUpdatesRequest()
        {
            Timeout = 2,
        });
        Console.WriteLine($"Маркер: {responseUpdates?.Marker}, Количество обновлений: {responseUpdates?.Updates.Count}");


        //var _ = maxApiClient.PollUpdatesWithCallback(
        //    async (update, client) =>
        //    {
        //        Console.WriteLine($"Сообщение: {update?.Message?.Body?.Text}");

        //        if (update?.UpdateType == UpdateTypes.MessageCreated)
        //        {
        //            await client.SendMessageAsync(new SendMessageRequest
        //            {
        //                Text = update.Message?.Body?.Text,
        //                ChatId = -70581633278133,
        //            });
        //        }
        //    },
        //    limit: 100,
        //    timeout: 90,
        //    types: new List<string> { UpdateTypes.MessageCreated }
        //);
    }
}