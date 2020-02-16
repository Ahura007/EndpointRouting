using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Endpoints
{
    public class SomeMiddleware
    {
        readonly RequestDelegate _next;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IActionContextAccessor _actionContextAccessor;
        public SomeMiddleware(RequestDelegate next, IHttpContextAccessor httpContextAccessor, IActionContextAccessor actionContextAccessor)
        {
            _next = next;
            _httpContextAccessor = httpContextAccessor;
            _actionContextAccessor = actionContextAccessor;
        }

        public async Task Invoke(HttpContext context)
        {
            var routeValues = _httpContextAccessor.HttpContext.Request;
            await _next(context);
        }
    }
}