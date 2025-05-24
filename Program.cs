using Library.API.GraphQL.Mutations;
using Library.API.GraphQL.Queries;
using Library.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<BookService>();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<BookQuery>()
    .AddMutationType<BookMutation>()
    .AddFiltering()
    .AddSorting(); ;

var app = builder.Build();
//app.Urls.Add("http://*:8080");
app.MapGraphQL();

app.Run();
