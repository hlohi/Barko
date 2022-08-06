using Barko.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barko.Data
{
    public class ApDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Logins.Any())
                {
                    context.Logins.AddRange(new List<Login>()
                    {
                        new Login()
                        {
                            
                            EmailAdrress = "Thabo@gmail.com",
                            Password = 123456789
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
        
        

        
    }
}
