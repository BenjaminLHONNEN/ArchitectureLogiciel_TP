using System.Collections.Generic;

namespace ArchiLogi.TP.Adapter
{
    /// <summary>
    /// Variable d'environment V2.
    /// </summary>
    public class DotEnvV2
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DotEnvV2"/>.
        /// </summary>
        public DotEnvV2()
        {
            Env = new Dictionary<string, string>();

            Env.Add("Host", "localhostV2");
            Env.Add("Port", "3615");
            Env.Add("User", "admin");
            Env.Add("Password", "123456");
        }

        /// <summary>
        /// Obtient ou définit les variables d'environment.
        /// </summary>
        public IDictionary<string, string> Env { get; set; }
    }
}
