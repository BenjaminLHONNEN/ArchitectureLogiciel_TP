namespace ArchiLogi.TP.Adapter
{
    /// <summary>
    /// Déclaration des méthode de récupération des variables d'environment.
    /// </summary>
    public interface IDotEnvAdapter
    {
        /// <summary>
        /// Récupère la valeur pour la clé.
        /// </summary>
        /// <param name="key">Nom de la clé.</param>
        /// <returns>Valeur.</returns>
        string Get(string key);
    }
}
