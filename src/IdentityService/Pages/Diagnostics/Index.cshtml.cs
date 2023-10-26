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
        // var localAddresses = new string[] {
        //     "::ffff:10.49.0.5", "10.49.0.5",
        //     "::ffff:10.126.0.2", "10.126.0.2",
        //     "::ffff:172.17.0.1", "172.17.0.1",
        //     "::ffff:172.18.0.1", "172.18.0.1",
        //     "::ffff:170.64.141.170", "170.64.141.170",
        //     "::ffff:10.5.0.6",
        //     "127.0.0.1", "::1", HttpContext.Connection.LocalIpAddress.ToString() };
        // if (!localAddresses.Contains(HttpContext.Connection.RemoteIpAddress.ToString()))
        // {
        //     return NotFound();
        // }

        View = new NewDiagnosticsPageViewModel(await HttpContext.AuthenticateAsync(), HttpContext.Connection.RemoteIpAddress.ToString());

        return Page();
    }
}

