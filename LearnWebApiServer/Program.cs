namespace LearnWebApiServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //הגדרות שנרצה להוסיף לפני בניית השרת
            
            var app = builder.Build();
            //תוספות שנרצה להוסיף לשרת
           



            app.Run();
        }
    }
}
