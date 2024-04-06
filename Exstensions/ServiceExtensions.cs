namespace LiftCommander_API.Exstensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder
                .AllowAnyOrigin()   // more restrict example: WithOrigins("https://example.com") which will allow requests only from that concrete source.
                .AllowAnyMethod()   // more restrict example: WithMethods("POST", "GET") that will allow only specific HTTP methods.
                .AllowAnyHeader()); // more restrict example: WithHeaders("accept", "content type") method to allow only specific headers.
            });


    }
}