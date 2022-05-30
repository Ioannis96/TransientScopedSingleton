using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace TransientScopedSingleton.Services
{
    public interface ICookieService
    {
        string GetCookie(string key);
        void CreateCookie(string key, string value);
        void DeleteCookie(string key);

    }
}
