using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaderAnalytics.MessageBox.Blazor;
public static class ExtensionMethods
{

    public static IServiceCollection AddMessageBoxBlazor(this IServiceCollection services)
    {
        services.AddScoped<IMessageBox, MessageBox>();
        return services;
    }
}
