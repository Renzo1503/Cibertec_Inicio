using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        //Segunda Forma
        public static IHtmlString DisplayPriceStatic(double price)
        {
            var result = string.Empty;
            result = (price == 0.0)? "<span> Free!!! </span>":$"<span>{price}</span>";            
            return new HtmlString(result);
        }
        //Tercera Forma
        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            var result = string.Empty;
            result = (price == 0.0) ? "<span> Free!!! </span>" : $"<span>{price}</span>";            
            return new HtmlString(result);
        }

        //**********Con Fecha**********
        //segunda  Forma con Fecha
        public static IHtmlString DisplayDateOrNullStatic(DateTime? createDate)
        {            
            return new HtmlString(GetHtmlForCreateDate(createDate));
        }
        //Tercera  Forma con Fecha
        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? createDate)
        {            
            return new HtmlString(GetHtmlForCreateDate(createDate));
        }
        //Funcion de condicional preferencia en private
        private static string GetHtmlForCreateDate(DateTime? date)
        {
            return date.HasValue? $"<span>{date.Value.ToString("dd-mm-yyyy")}</span>":"None";
        }

    }
}
