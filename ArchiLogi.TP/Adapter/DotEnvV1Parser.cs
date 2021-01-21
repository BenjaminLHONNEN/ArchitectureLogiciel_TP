namespace ArchiLogi.TP.Adapter
{
    /// <summary>
    /// Implémentation de la récupération des variables d'environment V1.
    /// </summary>
    public class DotEnvV1Parser : IDotEnvAdapter
    {
        private readonly DotEnvV1 _dotEnvV1;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="DotEnvV1Parser"/>.
        /// </summary>
        /// <param name="dotEnvV1">Information d'environment.</param>
        public DotEnvV1Parser(DotEnvV1 dotEnvV1)
        {
            _dotEnvV1 = dotEnvV1;
        }

        /// <summary>
        /// Récupère la valeur pour la clé.
        /// </summary>
        /// <param name="key">Nom de la clé.</param>
        /// <returns>Valeur.</returns>
        public string Get(string key)
        {
            return _dotEnvV1.GetType().GetProperty(key)?.GetValue(_dotEnvV1, null).ToString();
        }
    }
}
