using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomHtmlHelper.MyExtentionMethods
{
	public static class MyHtmlHelper
	{
		public static MvcHtmlString Submit(this HtmlHelper htmlHelper, string caption, string cssClass)
		{
			// 1st way to create 
			//string str = string.Format("<input type = \"submit\" value = \"{0}\" class = \"{1}\"", caption, cssClass);
			//return new MvcHtmlString(str);

			// 2nd way to create using TagBuilder class
			TagBuilder tagBuilder = new TagBuilder("input");
			tagBuilder.Attributes.Add("type", "submit");
			tagBuilder.Attributes["class"] = cssClass;
			tagBuilder.Attributes.Add(@"value", caption);
			return new MvcHtmlString(tagBuilder.ToString());
		}
	}
}