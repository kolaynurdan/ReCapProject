namespace ReCapProject.EntityLayer.Entityes
{
    using System;
    using System.ComponentModel;

    using ReCapProject.Common.Entity;

    public class Car :EntityBase, IEntity
    {
        /*
        Özellik olarak : Id, BrandId, ColorId, 
        ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)
        */
        /*
         public int Type { get; set; } 
         public string Type { get; set; }
        public bool Type { get; set; }
         */

        #region Brand
        public int BrandId { get; set; }
        public Brand Brands { get; set; }
        #endregion

        #region Color
        public int ColorId { get; set; }
        public Color Colors { get; set; }
        #endregion
        public int ModelYear { get; set; }

        public string Description { get; set; }

    }

   
}