using System.Linq;

namespace WebAPIAngulr23TF.Models.Constraints
{
    public class PasswordConstraint : IRouteConstraint
    {

        public PasswordConstraint()
        {

        }
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (values.ContainsKey("pwd"))
            {
                return values["pwd"].ToString().Length >= 8;
                
            }

            return false;
        }
    }
}
