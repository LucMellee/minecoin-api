using MineCoinApi.App.Shared;

namespace MineCoinApi.Controllers;

[ApiController]
[Route("wallet")]
public class WalletController
{
    private readonly IWalletService _walletService;
    
    public WalletController(IWalletService walletService)
    {
        _walletService = walletService;
    }
    
    [HttpGet("/health")]
    public string ControllerHealthCheck()
    {
        return "Controller is Healthy";
    }
    
    [HttpPost("/create")]
    public string CreateWallet()
    {
        return _walletService.CreateWallet();
    }
}