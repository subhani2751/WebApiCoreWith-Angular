namespace WebApiCoreWith_Angular.Iservices
{
    public interface ISTransactionService
    {
        string Withdrow(int id, double amount);

        string deposite(int id, double amount);
        string Transferamount(int senderid, double amount, int recipenitid);
    }
}
