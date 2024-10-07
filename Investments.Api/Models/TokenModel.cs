using Investments.Domain.Entities;

namespace Investments.Api.Models
{
    public class TokenModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public DataSource DataSource { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
