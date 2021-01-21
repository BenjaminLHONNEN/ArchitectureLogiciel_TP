namespace ArchiLogi.TP.Adapter
{
    public class DotEnvV1
    {
        public DotEnvV1()
        {
            Host = "localhostV1";
            Port = "3615";
            User = "admin";
            Password = "123456";
        }

        public string Host { get; set; }
        public string Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
