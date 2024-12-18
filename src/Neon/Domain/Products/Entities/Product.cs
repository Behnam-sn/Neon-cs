using Neon.Domain.Categories.Entities;
using Neon.Domain.CategoryAttributeValues.Entities;
using Neon.Domain.ProductAttributes.Entities;
using Neon.Domain.Reviews.Entities;
using Neon.Domain.Shared.Abstractions;
using Neon.Domain.ShopProducts.Entities;
using Neon.Domain.Tags.Entities;

namespace Neon.Domain.Products.Entities;

public sealed class Product : Entity
{
    public string Title { get; }
    public string Description { get; }
    public string Slug { get; }
    public Guid CategoryId { get; }

    // Navigations
    public Category Category { get; }
    public List<CategoryAttributeValue> CategoryAttributeValues { get; }
    public List<ProductAttribute> ProductAttributes { get; }
    public List<Tag> Tags { get; }
    public List<Review> Reviews { get; }
    public List<ShopProduct> ShopProducts { get; }

    // Extras
    public float AverageRate { get; }
    public int ReviewsCount { get; }
    public List<Product> RelatedProducts { get; }
    public List<object> Images { get; }
}
