using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1,2
            Product prd1 = new Product
            {
                Name = "Chips",
                BrendName = "Leys",
                Price = 2
            };
            Product prd2 = new Product
            {
                Name = "Yogurt",
                BrendName = "Aktivia",
                Price = 1
            };
            Product prd3 = new Product
            {
                Name = " Saqqiz",
                BrendName = "Dirol",
                Price = 1
            };
        }
        #endregion
    }
}
