﻿using eCom.Web.Service.IService;
using eCom.Web.Utility;
using System.Diagnostics.Eventing.Reader;

namespace eCom.Web.Service
{
    public class TokenProvider : ITokenProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public TokenProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public void ClearToken()
        {
            _contextAccessor.HttpContext?.Response.Cookies.Delete(SD.TokenCookies);
        }

        public string? GetToken()
        {
            string? token = null;
            bool? hasToken = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(SD.TokenCookies, out token); 
            return hasToken is true ? token : null;
        }

        public void SetToken(string token)
        {
            _contextAccessor.HttpContext?.Response.Cookies.Append(SD.TokenCookies, token);
        }
    }
}
