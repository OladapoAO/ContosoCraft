using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoCrafts.Website.Services;
using ContosoCrafts.Website.Models;

namespace ContosoCrafts.Website.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IJsonFileProductService _productService;

    public IEnumerable<Product> Products { get; private set; }

    public IndexModel(ILogger<IndexModel> logger, IJsonFileProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    public void OnGet() //HTTP calls
    {
       Products = _productService.GetProducts();
    }
}

