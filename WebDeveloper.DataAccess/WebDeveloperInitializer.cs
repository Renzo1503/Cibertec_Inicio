using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb> //heredar la funcionalida propida del dataentity
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client { Name="Jose", Apellido="Párez"},
                new Client { Name="Juan", Apellido="Párez"},
                new Client { Name="Juanelo", Apellido="Párez"},
                new Client { Name="Renzo", Apellido="Párez"},
                new Client { Name="Victor", Apellido="Párez"},
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }

    }
}
