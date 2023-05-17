using Lunar.EightChar;
using YiJingFramework.PrimitiveTypes;

namespace LunarCsharpYiJingFrameworkExtensions;
public static class EightCharExtensions
{
    public static Tiangan YearGan(this EightChar eightChar)
    {
        return new(eightChar.Lunar.YearGanIndexExact + 1);
    }
    public static Dizhi YearZhi(this EightChar eightChar)
    {
        return new(eightChar.Lunar.YearZhiIndexExact + 1);
    }

    public static Tiangan MonthGan(this EightChar eightChar)
    {
        return new(eightChar.Lunar.MonthGanIndexExact + 1);
    }
    public static Dizhi MonthZhi(this EightChar eightChar)
    {
        return new(eightChar.Lunar.MonthZhiIndexExact + 1);
    }

    public static Tiangan DayGan(this EightChar eightChar)
    {
        return new(eightChar.DayGanIndex + 1);
    }
    public static Dizhi DayZhi(this EightChar eightChar)
    {
        return new(eightChar.DayZhiIndex + 1);
    }

    public static Tiangan TimeGan(this EightChar eightChar)
    {
        return new(eightChar.Lunar.TimeGanIndex + 1);
    }
    public static Dizhi TimeZhi(this EightChar eightChar)
    {
        return new(eightChar.Lunar.TimeZhiIndex + 1);
    }
}
