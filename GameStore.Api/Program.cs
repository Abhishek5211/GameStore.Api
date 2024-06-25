using GameStore.Api.Dtos;
using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games = [
    new (
1,
"Street Fighter II" ,
"Fighting" ,
    19.99M,
new DateOnly(1992, 7, 22)),
new (
2,
"Final Fantasy XIV",
" Roleplaying" ,
    59.99M,
new DateOnly(2010, 9, 15))
,new (
3,
"FIFA",
"Sports" ,
69.99M,
new DateOnly(2022,
9,27))];

app.MapGet("games", () => games);

app.MapGet("games/{id}", (int id) => games.Find(game=> game.Id == id ));


app.Run();
