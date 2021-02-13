using ApiKeyAuthDemo.Filters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MReportAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class ApiKeyAuthorizeAttribute : TypeFilterAttribute
	{
		public ApiKeyAuthorizeAttribute() : base(typeof(ApiKeyAuthorizeAsyncFilter))
		{
		}
	}
}
