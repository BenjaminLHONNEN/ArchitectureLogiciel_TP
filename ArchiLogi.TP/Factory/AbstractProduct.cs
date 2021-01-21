using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiLogi.TP.Factory
{
    /// <summary>
    /// Produit du 
    /// </summary>
    public abstract class AbstractProduct
    {
        private string _name;
        private decimal _price;

        /// <summary>
        /// Obtient le nom.
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Obtient le prix.
        /// </summary>
        public decimal Price => _price;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="AbstractProduct"/>.
        /// </summary>
        /// <param name="name">Nom du produit.</param>
        /// <param name="price">Prix du produit</param>
        public AbstractProduct(string name, decimal price)
        {
            _name = name;
            _price = price;
        }
    }
}
