using System;

namespace ArchiLogi.TP.Factory
{
    /// <summary>
    /// Usine de construction des produits.
    /// </summary>
    public class ProductFactory
    {
        /// <summary>
        /// Créé un produit en fonctiondesz paramètre donné.
        /// </summary>
        /// <param name="type">Type du produit.</param>
        /// <param name="name">Nom du produit.</param>
        /// <param name="price">Prix du produit.</param>
        /// <param name="size">Taille du produit.</param>
        /// <returns>Produit créé.</returns>
        public AbstractProduct CreateProduct(Type type, string name, decimal price, dynamic size)
        {
            if (type == typeof(Shoes) && size is decimal)
            {
                return new Shoes(name, price, size);
            }
            if (type == typeof(Clothe) && size is ClotheProduct)
            {
                return new Clothe(name, price, size);
            }

            return null;
        }
    }
}
