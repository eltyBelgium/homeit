using System;
using System.Collections.Generic;
using System.Linq;
using API.DB;
using API.Models;

namespace API.Data
{
    public class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Electricity.Any() || !context.Gas.Any() || !context.Water.Any() ||!context.Errors.Any())
                return;

            var userGuid = Guid.NewGuid();
            var Electricty = new List<Electricity>();
            var Gas = new List<Gas>();
            var Water = new List<Water>();

            Electricty.Add(new Electricity()
            {
                TimeStamp = DateTime.Now,
                Used = 3000,
                UserGuid = userGuid,
            });

            Electricty.Add(new Electricity()
            {
                TimeStamp = DateTime.Now,
                Used = 2000,
                UserGuid = userGuid,
            });

            Electricty.Add(new Electricity()
            {
                TimeStamp = DateTime.Now,
                Used = 1000,
                UserGuid = userGuid,
            });

            Gas.Add(new Gas()
            {
                TimeStamp = DateTime.Now,
                Used = 3000,
                UserGuid = userGuid,
            });
            Gas.Add(new Gas()
            {
                TimeStamp = DateTime.Now,
                Used = 2000,
                UserGuid = userGuid,
            });
            Gas.Add(new Gas()
            {
                TimeStamp = DateTime.Now,
                Used = 1000,
                UserGuid = userGuid,
            });
            
            Water.Add(new Water()
            {
                TimeStamp = DateTime.Now,
                Used = 3000,
                UserGuid = userGuid,
            });
            Water.Add(new Water()
            {
                TimeStamp = DateTime.Now,
                Used = 2000,
                UserGuid = userGuid,
            });
            Water.Add(new Water()
            {
                TimeStamp = DateTime.Now,
                Used = 1000,
                UserGuid = userGuid,
            });


            foreach (var water in Water)
            {
                context.Water.Add(water);
            }
            foreach (var gase in Gas)
            {
                context.Gas.Add(gase);
            }
            foreach (var electricity in Electricty)
            {
                context.Electricity.Add(electricity);
            }
            context.SaveChanges();
        }
    }
}