using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

namespace TransientScopedSingleton.Services
{
    public class CookieService : ICookieService
    {
        private readonly HttpContext _context;
        public CookieService(IHttpContextAccessor contextAccesor)
        {
            _context = contextAccesor.HttpContext;
        }


        public void CreateCookie(string key, string value)
        {
            _context.Response.Cookies.Append(key, value);

        }

        public void DeleteCookie(string key)
        {
            throw new System.NotImplementedException();
        }

        public string GetCookie(string key)
        {
            throw new System.NotImplementedException();
        }
    }
}
