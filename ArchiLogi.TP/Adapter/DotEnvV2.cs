using System.Collections.Generic;

namespace ArchiLogi.TP.Adapter
{
    public class DotEnvV2
    {
        public DotEnvV2()
        {
            Env = new Dictionary<string, string>();

            Env.Add("Host", "localhostV2");
            Env.Add("Port", "3615");
            Env.Add("User", "admin");
            Env.Add("Password", "123456");
        }

        public IDictionary<string, string> Env { get; set; }
    }
}
