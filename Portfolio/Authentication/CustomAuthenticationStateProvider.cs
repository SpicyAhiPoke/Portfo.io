using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Security.Claims;

namespace Portfolio.Authentication
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly ProtectedSessionStorage sessionstore;
        private ClaimsPrincipal anon = new(new ClaimsIdentity());

        public CustomAuthenticationStateProvider(ProtectedSessionStorage authsession)
        {
            sessionstore = authsession;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                var storeresult = await sessionstore.GetAsync<UserSession>("UserSession");
                var usersession = storeresult.Success ? storeresult.Value : null;
                if (usersession == null)
                {
                    return await Task.FromResult(new AuthenticationState(anon));
                }
                else
                {
                    var claimsp = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, usersession.Username),
                        new Claim(ClaimTypes.Role, usersession.Role)
                    }, "CustomAuth"));
                    return await Task.FromResult(new AuthenticationState(claimsp));
                }
            }
            catch
            {
                return await Task.FromResult(new AuthenticationState(anon));
            }
        }

        //login/logout
        public async Task UpdateAuthenticationStateAsync(UserSession usersession)
        {
            ClaimsPrincipal claimsp;

            if (usersession == null)
            {
                await sessionstore.DeleteAsync("UserSession");
                claimsp = anon;
            }
            else
            {
                await sessionstore.SetAsync("UserSession", usersession);
                claimsp = new ClaimsPrincipal(new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usersession.Username),
                    new Claim(ClaimTypes.Role, usersession.Role)
                }));
            }

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsp)));
        }
    }
}
