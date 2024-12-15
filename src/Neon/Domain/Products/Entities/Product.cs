using Neon.Domain.Categories.Entities;
using Neon.Domain.Reviews.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.Shops.Entities;
using Neon.Domain.Tags.Entities;

namespace Neon.Domain.Products.Entities;

public sealed class Product : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public float AverageRate { get; private set; }
    public int ReviewsCount { get; private set; }
    public string Slug { get; private set; }
    public Category Category { get; private set; }
    public List<CategoryAttributeValue> CategoryAttributeValues { get; private set; }
    public List<object> Images { get; private set; }
    public List<Tag> Tags { get; private set; }
    public List<Review> Reviews { get; private set; }
    public List<Product> RelatedProducts { get; private set; }
    public List<ShopProduct> ShopProductAssignments { get; private set; }
}
