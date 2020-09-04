using Microsoft.Extensions.DependencyInjection;
using BookTransactionAPI.Services.Concrete;
using BookTransactionAPI.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTransactionAPI.Services.DI
{
    public class ServiceRegistry
    {
        public void ConfigureServiceRegistries(IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
        }
    }
}
