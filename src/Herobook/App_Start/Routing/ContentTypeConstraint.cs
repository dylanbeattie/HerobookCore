//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Web.Http.Routing;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Routing;

//namespace Herobook.Routing {
//    // Code from http://massivescale.com/web-api-routing-by-content-type/
//    internal class ContentTypeConstraint : IRouteConstraint {
//        public ContentTypeConstraint(string allowedMediaType) {
//            AllowedMediaType = allowedMediaType;
//        }

//        public string AllowedMediaType { get; private set; }

//        private string GetMediaHeader(HttpRequest request) {
//	        var contentTypes = request.Headers["Content-Type"];
//	        return contentTypes.Count == 1 ? contentTypes.First() : "application/x-www-form-urlencoded";
//        }

//	    public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection) {
//		    if (routeDirection == RouteDirection.IncomingRequest) {
//			    return (GetMediaHeader(httpContext.Request) == AllowedMediaType);
//		    }
//		    return (true);
//	    }
//    }
//}