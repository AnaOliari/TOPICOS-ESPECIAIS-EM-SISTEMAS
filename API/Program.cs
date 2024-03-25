var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>()

{
  new Produto("Celular", "Android"),
  new Produto("Televisao", "Sansung"),
  new Produto("Celular", "Iphone")
};

app.MapGet("/", () => "Hello World!");
app.MapPost("/api/produto", () => produtos);
// cadastrar um produto na lista produto 
app.Run();

public record Produto(string Nome, string Descricao);