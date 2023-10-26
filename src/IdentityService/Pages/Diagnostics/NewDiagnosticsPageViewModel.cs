using Microsoft.AspNetCore.Authentication;

namespace IdentityService.Pages.Diagnostics;
public class NewDiagnosticsPageViewModel : ViewModel
{
    public NewDiagnosticsPageViewModel(AuthenticateResult result, string remoteIpAddress) : base(result)
    {
        this.RemoteIpAddress = remoteIpAddress;
    }
    public string RemoteIpAddress { get; }
}