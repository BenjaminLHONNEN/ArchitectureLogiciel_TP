namespace ArchiLogi.TP.Adapter
{
    /// <summary>
    /// Implémentation de la récupération des variables d'environment V2.
    /// </summary>
    public class DotEnvV2Parser : IDotEnvAdapter
    {
        private readonly DotEnvV2 _dotEnvV2;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DotEnvV2Parser"/>.
        /// </summary>
        /// <param name="dotEnvV2">Information d'environment.</param>
        public DotEnvV2Parser(DotEnvV2 dotEnvV2)
        {
            _dotEnvV2 = dotEnvV2;
        }

        /// <summary>
        /// Récupère la valeur pour la clé.
        /// </summary>
        /// <param name="key">Nom de la clé.</param>
        /// <returns>Valeur.</returns>
        public string Get(string key)
        {
            return _dotEnvV2.Env[key];
        }
    }
}
