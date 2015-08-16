using System;

namespace AppPracticeService.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            ProductId = Guid.NewGuid();
        }
        public Guid ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double NewPrice { get; set; }
        public string Category { get; set; }
        public string SizeS { get; set; }
        public string SizeM { get; set; }
        public string SizeL { get; set; }
        public string Material { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Color3 { get; set; }
        public string Color4 { get; set; }
        public string Color5 { get; set; }
        public string Model { get; set; }
        public int SeasonMonth { get; set; }
        public int SeasonYear { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifieldDate { get; set; }
        public bool Active { get; set; }

        public PictureProductModel[] Pictures { get; set; }

    }
}
