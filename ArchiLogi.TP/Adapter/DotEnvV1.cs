namespace ArchiLogi.TP.Adapter
{
    public class DotEnvV1
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DotEnvV1"/>.
        /// </summary>
        public DotEnvV1()
        {
            Host = "localhostV1";
            Port = "3615";
            User = "admin";
            Password = "123456";
        }

        /// <summary>
        /// Obtient ou définit l'hote.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Obtient ou définit le port.
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'utilisateur.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Obtient ou définit le mot de passe.
        /// </summary>
        public string Password { get; set; }
    }
}
