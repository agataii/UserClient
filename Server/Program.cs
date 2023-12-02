using Newtonsoft.Json;
using System.Net;
using System.Text;
using UserCommon;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<User> users = new List<User>()
{
    new User() {
        Id = 0,
        Name = "Admin",
        Email="Admin@admin.com",
        Birthday = new DateTime(1998,1,22),
        Password="admin" },
};

app.MapGet("/", () => "Hello World!");

app.MapGet("/users", async (context) =>
{
    context.Response.ContentType = "application/json";

    context.Response.WriteAsJsonAsync(users);
});

app.MapPost("/user/create", async (HttpContext context, User newUser) =>
{
    newUser.Id = users[users.Count - 1].Id + 1;

    if (users.Any((user) => user.Email == newUser.Email))
    {
        context.Response.StatusCode = (int)HttpStatusCode.Conflict; // 409
        context.Response.WriteAsync("Пользователь с такой почтой уже существует", Encoding.UTF8);
    }
    else
    {
        users.Add(newUser);

        context.Response.WriteAsync("Пользователь " + newUser.Name + " создан!", Encoding.UTF8);
    }
});

app.MapDelete("/user/delete", async (HttpContext context, int id) =>
{
    User findUser = users.Find(x => x.Id == id);

    if (findUser is null)
    {
        context.Response.StatusCode = (int)HttpStatusCode.NotFound;
        context.Response.WriteAsync("Такого пользователя не существует", Encoding.UTF8);
    }
    else
    {
        users.Remove(findUser);
        context.Response.WriteAsync($"Ползователь с ID: {id} был удален", Encoding.UTF8);
    }
});
app.Run();