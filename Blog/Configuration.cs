namespace Blog;

public static class Configuration
{
    public static string ApiKeyName = "api_Key";

    public static string ApiKey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";

    public static SmtpConfiguration Smtp = new();

    public static string JwtKey { get; set; } = "DkeLrOMc3ky4cc65ZCy04w==";

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
