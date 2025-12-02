using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreWith_Angular.Iservices;
using WebApiCoreWith_Angular.Models;
using WebApiCoreWith_Angular.Services;

namespace WebApiCoreWith_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmountTransferController : ControllerBase
    {
        public readonly ITransactionService _transactionService;
        public AmountTransferController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        [HttpPost("Transferamount")]
        public ActionResult<string> Transferamount([FromBody] AccountModel accountModel)
        {
            return _transactionService.Transferamount(senderid: accountModel.iAid, amount: accountModel.dBalance , recipenitid : accountModel.recipenitid);
            //ISTransactionService a = new STransactionService();
            //return a.Transferamount(senderid: accountModel.iAid, amount: accountModel.dBalance, recipenitid: accountModel.recipenitid);
            //TransactionService a = new TransactionService();
            //return a.Transferamount(senderid: accountModel.iAid, amount: accountModel.dBalance, recipenitid: accountModel.recipenitid);
        }
    }
}
