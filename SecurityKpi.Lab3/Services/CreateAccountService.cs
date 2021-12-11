using SecurityKpi.Lab3.Models;

namespace SecurityKpi.Lab3.Services;

public class CreateAccountService
{
    public async Task<Account> CreateAccount(int id)
    {
        return new Account(id);
    }
}