using Community.Api.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();
app.UseHttpsRedirection();

app.MapGet("/api/communities", () =>
{
    var communities = new List<CommunityOption> {
        new(1, "Slack Community", "https://images.icon-icons.com/2429/PNG/512/slack_logo_icon_147236.png", "slack.com"),
        new(2, "Discord Helpline", "https://static.vecteezy.com/system/resources/previews/018/930/718/non_2x/discord-logo-discord-icon-transparent-free-png.png", "discord.com")
    };

    return Results.Ok(communities);
});

app.Run();