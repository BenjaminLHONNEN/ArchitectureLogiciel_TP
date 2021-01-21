using System;
using System.Collections.Generic;

namespace ArchiLogi.TP.Factory
{
    /// <summary>
    /// Entré du programme des factory.
    /// </summary>
    public class FactoryProgram
    {
        public static void FactoryMain(string[] args)
        {
            Random rng = new Random();
            ProductFactory productFactory = new ProductFactory();

            List<AbstractProduct> abstractProducts = new List<AbstractProduct>();

            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S1", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S2", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S3", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S4", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S5", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S6", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S7", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Shoes), "S8", NextDecimal(rng), NextDecimal(rng)));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C1", NextDecimal(rng),
                ClotheProduct.XS));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C2", NextDecimal(rng), ClotheProduct.S));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C3", NextDecimal(rng), ClotheProduct.L));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C4", NextDecimal(rng), ClotheProduct.M));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C5", NextDecimal(rng),
                ClotheProduct.XL));
            abstractProducts.Add(
                productFactory.CreateProduct(typeof(Clothe), "C6", NextDecimal(rng), ClotheProduct.XXL));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C7", NextDecimal(rng), ClotheProduct.S));
            abstractProducts.Add(productFactory.CreateProduct(typeof(Clothe), "C8", NextDecimal(rng),
                ClotheProduct.XL));

            System.Console.ReadLine();
        }

        /// <summary>
        /// Integer aléatoire.
        /// </summary>
        /// <param name="rng">Random.</param>
        /// <returns>Integer.</returns>
        public static int NextInt32(Random rng)
        {
            int firstBits = rng.Next(0, 1 << 4) << 28;
            int lastBits = rng.Next(0, 1 << 28);
            return firstBits | lastBits;
        }

        /// <summary>
        /// Decimal aléatoire.
        /// </summary>
        /// <param name="rng">Random.</param>
        /// <returns>Décimal</returns>
        public static decimal NextDecimal(Random rng)
        {
            byte scale = (byte) rng.Next(29);
            bool sign = rng.Next(2) == 1;
            return new decimal(NextInt32(rng),
                NextInt32(rng),
                NextInt32(rng),
                sign,
                scale);
        }
    }
}