using LRR.Catalogo.API.Data;
using LRR.Catalogo.API.Data.Repository;
using LRR.Catalogo.API.Models;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.DependencyInjection;

namespace LRR.Catalogo.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegistrarServices(this IServiceCollection services)
        {
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
