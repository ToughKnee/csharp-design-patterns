namespace BuilderPattern
{
    public class SkuCodeStartDiscountStrategy : IDiscountStrategy
    {
        public int DiscountInPercentage { get; set; }
        public string SkuCodeStart { get; set;}
        public decimal CalculateDiscountedRetailPrice(Product product)
        {
            if (!product.StockKeepingUnit.StartsWith(SkuCodeStart))
            {
                return product.RegularRetailPrice;
            }
            
            return product.RegularRetailPrice - (DiscountInPercentage/100m * product.RegularRetailPrice);
        }

    }
}