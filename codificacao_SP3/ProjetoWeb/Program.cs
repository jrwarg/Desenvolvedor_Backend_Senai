namespace ProjetoWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.UseStaticFiles();

        app.MapGet("/", () => "Hello World!");
        app.MapGet("/clientes", () => "Clientes !!!!");
        // app.MapGet("/produtos", () => "Produtos !!!!");
        app.MapGet("/produtos", (HttpContext contexto) =>
            {
            contexto.Response.Redirect("produtos.html", false);
            }
        );
        app.MapGet("/cliente", (string nome, string email) => $"O nome do cliente é: {nome} \nO Email é: {email}");

        app.Run();
    }
}
