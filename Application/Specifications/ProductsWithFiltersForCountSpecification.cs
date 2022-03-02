using Domain;

namespace Application.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
         
        private ProductSpecParams productParams;

        public ProductsWithFiltersForCountSpecification(ProductSpecParams productParams)
            : base(x =>
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower()
                    .Contains(productParams.Search)) &&
                (!productParams.BrandId.HasValue || x.ProductBrandId == productParams.BrandId)
                && (!productParams.TypeId.HasValue || x.ProductTypeId == productParams.TypeId)
            )
        {
        }
    }
}
