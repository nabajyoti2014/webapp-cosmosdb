using Microsoft.AspNetCore.Mvc.RazorPages;
using cosmosdb.Models;
using cosmosdb.Services;

namespace cosmosdb.Pages;

public class IndexPageModel : PageModel
{
    private readonly ICosmosService _cosmosService;

    public IEnumerable<Product>? Products { get; set; }

    public IndexPageModel(ICosmosService cosmosService)
    {
        _cosmosService = cosmosService;
    }

    public async Task OnGetAsync()
    {
        Products ??= await _cosmosService.RetrieveActiveProductsAsync();
    }
}