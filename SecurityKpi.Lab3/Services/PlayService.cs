using SecurityKpi.Lab3.Generators;
using SecurityKpi.Lab3.Models;

namespace SecurityKpi.Lab3.Services;

public class PlayService
{
    private readonly LcgGenerator _lcgGenerator = new LcgGenerator();
    private readonly MtGenerator _mtGenerator = new MtGenerator();
    private readonly BetterMtGenerator _betterMtGenerator = new BetterMtGenerator();

    public Response PlayLcg(Account account, int bet, int number)
    {
        var result = _lcgGenerator.Next();
        if (number == result)
        {
            account.Money += bet * 1000;
            return new Response() { Message = "U won!", Account = account, RealNumber = result};
        }
        else
        {
            account.Money -= bet;
            return new Response() { Message = "U lost!", Account = account, RealNumber = result};
        }
    }
    // public Response PlayMt(Account account, int bet, int number)
    // {
    //     var result = _mtGenerator;
    // }
    // public Response PlayBetterMt(Account account, int bet, int number)
    // {
    //     var result = _betterMtGenerator;
    // }
}