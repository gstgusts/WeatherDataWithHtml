namespace WeatherData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddCors();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.UseCors(bd => bd
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());

            app.Run();
        }
    }
}