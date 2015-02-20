using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://noreenFirstWebService.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

     
    [WebMethod(Description = "add two numbers")]
        public int add(int nbr1, int nbr2)
        {
            return nbr1 + nbr2;
        }

    [WebMethod(Description = "multiply two numbers")]
    public int mul(int nbr1, int nbr2)
    {
        return nbr1 * nbr2;
    }
    
    
    }
}
