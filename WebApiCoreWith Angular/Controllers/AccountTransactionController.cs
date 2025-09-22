using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreWith_Angular.Iservices;
using WebApiCoreWith_Angular.Models;
using WebApiCoreWith_Angular.Services;

namespace WebApiCoreWith_Angular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTransactionController: ControllerBase
    {
        //public readonly ITransactionService _transactionService;
        //public AccountTransactionController(ITransactionService transactionService)
        //{
        //    _transactionService = transactionService;
        //}
        [HttpPost("WithdrowTRans")]
        public ActionResult<string> WithdrowTRans([FromBody] AccountModel accountModel)
        {
            //return _transactionService.Withdrow(accountModel.iAid, accountModel.dBalance);
            //ISTransactionService a = new STransactionService();
            //return a.Withdrow(accountModel.iAid, accountModel.dBalance);
            TransactionService a = new TransactionService();
            return a.Withdrow(accountModel.iAid, accountModel.dBalance);

        }
        [HttpPost("DepositeTRans")]
        public ActionResult<string> DepositeTRans([FromBody] AccountModel accountModel)
        {
            //return _transactionService.deposite(accountModel.iAid, accountModel.dBalance);
            //ISTransactionService a = new STransactionService();
            //return a.deposite(accountModel.iAid, accountModel.dBalance);
            TransactionService a = new TransactionService();
            return a.deposite(accountModel.iAid, accountModel.dBalance);
        }
    }
}
