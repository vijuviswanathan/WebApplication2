using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2.Services;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {

        public List<Product> Products;

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        { 
            _productService = productService;

        }
        
        public void OnGet()
        {
          //  ProductService productService = new ProductService();
            Products = _productService.GetProducts();

        }
    }
}
