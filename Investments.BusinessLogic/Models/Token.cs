namespace Investments.BusinessLogic.Models
{
    public class Token
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
        public DataSource DataSource { get; set; }
    }
}
