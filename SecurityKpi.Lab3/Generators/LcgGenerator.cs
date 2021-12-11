namespace SecurityKpi.Lab3.Generators;

public class LcgGenerator
{
    private const long M = 4294967296;
    private const long A = 1664525;
    private const long C = 1013904223;
    private long _last;

    public LcgGenerator()
    {
        _last = DateTime.Now.Ticks % M;
    }

    public LcgGenerator(long seed)
    {
        _last = seed;
    }
    public long Next()
    {
        _last = ((A * _last) + C) % M;
        return _last;
    }
    public long Next(long maxValue)
    {
        return Next() % maxValue;
    }
}