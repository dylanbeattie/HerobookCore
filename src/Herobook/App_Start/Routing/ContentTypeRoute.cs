//using System.Collections.Generic;
//using Microsoft.AspNetCore.Routing;


//namespace Herobook.Routing
//{
//	// Code from http://massivescale.com/web-api-routing-by-content-type/
//	public class ContentTypeRoute : RouteFactoryAttribute
//	{
//		public ContentTypeRoute(string template, string contentType)
//			: base(template)
//		{
//			ContentType = contentType;
//		}

//		public override IDictionary<string, object> Constraints {
//			get {
//				var constraints = new RouteValueDictionary();
//				constraints.Add("Content-Type", new ContentTypeConstraint(ContentType));
//				return constraints;
//			}
//		}

//		public string ContentType { get; private set; }
//	}
//}