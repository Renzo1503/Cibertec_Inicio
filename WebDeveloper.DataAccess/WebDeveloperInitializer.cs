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
                new Client { Name="Jose", LastName="Párez"},
                new Client { Name="Juan", LastName="Párez"},
                new Client { Name="Juanelo", LastName="Párez"},
                new Client { Name="Renzo", LastName="Párez"},
                new Client { Name="Victor", LastName="Párez"},
            };

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }

    }
}
