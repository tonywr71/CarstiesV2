using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace IdentityService.Pages.Diagnostics;

[SecurityHeaders]
[Authorize]
public class Index : PageModel
{
    public NewDiagnosticsPageViewModel View { get; set; }

    public async Task<IActionResult> OnGet()
    {
        var localAddresses = new string[] {
            "::ffff:172.18.0.2",
            "127.0.0.1", "::1", HttpContext.Connection.LocalIpAddress.ToString() };
        if (!localAddresses.Contains(HttpContext.Connection.RemoteIpAddress.ToString()))
        {
            return NotFound();
        }

        View = new NewDiagnosticsPageViewModel(await HttpContext.AuthenticateAsync(), HttpContext.Connection.RemoteIpAddress.ToString());

        return Page();
    }
}

