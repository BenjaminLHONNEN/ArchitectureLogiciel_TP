namespace ArchiLogi.TP.Factory
{
    /// <summary>
    /// Modele de chaussure.
    /// </summary>
    public class Shoes : AbstractProduct
    {
        /// <summary>
        /// Obtient la taille des produits.
        /// </summary>
        public decimal Size { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Shoes"/>.
        /// </summary>
        /// <param name="name">Nom du produit.</param>
        /// <param name="price">Prix du produit.</param>
        /// <param name="size">Taille du produit.</param>
        public Shoes(string name, decimal price, decimal size) : base(name, price)
        {
            Size = size;
        }
    }
}
