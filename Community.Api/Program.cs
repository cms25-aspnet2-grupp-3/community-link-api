using Community.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();

app.MapGet("/api/communities", () =>
{
    var communities = new List<CommunityOption> {
        new(1, "Slack Community", "https://shikoimagestorage.blob.core.windows.net/images/Community/slack-icon.png", "slack.com"),
        new(2, "Discord Helpline", "https://shikoimagestorage.blob.core.windows.net/images/Community/discord-icon.png", "discord.com")
    };

    return Results.Ok(communities);
});

app.Run();