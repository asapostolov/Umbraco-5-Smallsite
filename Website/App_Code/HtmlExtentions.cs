using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/// <summary>
/// Provides extention methods for Umbraco 5
/// </summary>
public static class HtmlExtentions
{
	public static dynamic GetNodeWithName(this HtmlHelper helper, object currentNode, string nodeName)
	{
        dynamic result = currentNode;

        while (result.ContentType.Alias != nodeName)
        {
            result = result.Parent;
        }

        return result;
	}
}