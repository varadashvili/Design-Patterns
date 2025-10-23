namespace Facade_Demo;

internal class AccountCategoryService
{
    private Dictionary<int, AccountCategory> accountCategories;

    public AccountCategoryService()
    {
        accountCategories = new()
        {
            { 1, AccountCategory.Buyer },
            { 2, AccountCategory.Buyer },
            { 3, AccountCategory.Reseller },
            { 4, AccountCategory.Reseller }
        };
    }

    public AccountCategory GetCategory(int accountId)
    {
        return accountCategories[accountId];
    }
}

internal enum AccountCategory
{
    Buyer = 1,
    Reseller = 2
}