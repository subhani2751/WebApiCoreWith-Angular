using WebApiCoreWith_Angular.Iservices;
using WebApiCoreWith_Angular.Models;

namespace WebApiCoreWith_Angular.Services
{
    public class TransactionService: ITransactionService
    {
        public  List<AccountModel> TransactionList { get; set; } = new List<AccountModel>
        {
            new AccountModel { iAid = 1, dBalance = 1000 },
            new AccountModel { iAid = 2, dBalance = 500 },
            new AccountModel { iAid = 3, dBalance = 1000 },
            new AccountModel { iAid = 4, dBalance = 500 }
        };

        public string Withdrow(int id, double amount)
        {
            string sReturn = string.Empty;
            if (TransactionList.Count(x => x.iAid == id && x.dBalance >= amount) > 0)
            {
                var a = TransactionList.Where(x => x.iAid == id && x.dBalance >= amount).ToList()[0];
                double bal = a.dBalance - amount;
                TransactionList.Where(x => x.iAid == id && x.dBalance >= amount).ToList()[0].dBalance = bal;
                sReturn = "transaction is done successfully";
            }
            else
            {
                sReturn = "transaction is not done..";
            }
            return sReturn;
        }
        public string deposite(int id, double amount)
        {
            string sReturn = string.Empty;
            if (TransactionList.Count(x => x.iAid == id && amount > 0) > 0)
            {
                var a = TransactionList.Where(x => x.iAid == id).ToList()[0];
                double bal = a.dBalance + amount;
                TransactionList.Where(x => x.iAid == id).ToList()[0].dBalance = bal;
                sReturn = "transaction is done successfully";
            }
            else
            {
                sReturn = "transaction is not done..";
            }
            return sReturn;
        }
        public string Transferamount(int senderid, double amount, int recipenitid)
        {
            string sReturn = string.Empty;
            if (amount > 0 && TransactionList.Count(x => x.iAid == senderid && x.dBalance >= amount) > 0 && TransactionList.Count(x => x.iAid == recipenitid) > 0)
            {
                var a = TransactionList.Where(x => x.iAid == senderid).ToList()[0];
                double bal = a.dBalance - amount;
                TransactionList.Where(x => x.iAid == senderid).ToList()[0].dBalance = bal;
                TransactionList.Where(x => x.iAid == recipenitid).ToList()[0].dBalance += amount;
                sReturn = "transaction is done successfully";
            }
            else
            {
                sReturn = "transaction is not done..";
            }
            return sReturn;
        }
    }
}
