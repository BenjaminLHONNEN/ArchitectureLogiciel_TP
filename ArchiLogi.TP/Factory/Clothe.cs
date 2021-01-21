namespace ArchiLogi.TP.Factory
{
    /// <summary>
    /// Modèle d'habit.
    /// </summary>
    public class Clothe : AbstractProduct
    {
        /// <summary>
        /// Obtient la taille des produits.
        /// </summary>
        public ClotheProduct Size { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Clothe"/>.
        /// </summary>
        /// <param name="name">Nom du produit.</param>
        /// <param name="price">Prix du produit.</param>
        /// <param name="size">Taille du produit.</param>
        public Clothe(string name, decimal price, ClotheProduct size) : base(name, price)
        {
            Size = size;
        }
    }
}
