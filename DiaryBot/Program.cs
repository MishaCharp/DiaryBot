using Vkontakte.Bot;

VkontakteBot VkBot;

VkBot = new VkontakteBot();
VkBot.Authorization("vk1.a.KML3tb-mJberd0KlmqvNc7I-ZYkz1ZmbLFmspno0_TylONHFn0f-R1h2yP_wSaTDJG7ZhidE3GDsec-7ZD02_s7MVx5nHiBblODJH0LidtcM-36HRi3gcH9LzjLwoEQxUkzzxR_nhlYql8bA2dfyY7UWGULgw2zwbJBwOkOND64vQSvmwr55wwJwUV6EPe3Z");
VkBot.Start(Handle);

Console.ReadLine();

void Handle(long id, string text)
{
    VkBot.Send(id, "Hello World");
}

