using Cappy.SDK.Interfaces;
using Cappy.SDK.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Cappy.SDK.Modules;

public static class CappyModule
{
    public static IServiceCollection AddCappySdk(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<ICappyService, CappyService>();
        return serviceCollection;
    }
}