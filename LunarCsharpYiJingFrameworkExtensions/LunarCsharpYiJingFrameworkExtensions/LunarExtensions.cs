using LLunar = Lunar.Lunar;
using YiJingFramework.PrimitiveTypes;

namespace LunarCsharpYiJingFrameworkExtensions;
public static class LunarExtensions
{
    public static Tiangan YearGan(this LLunar lunar)
    {
        return new(lunar.YearGanIndex + 1);
    }
    public static Dizhi YearZhi(this LLunar lunar)
    {
        return new(lunar.YearZhiIndex + 1);
    }

    public static Tiangan YearGanExact(this LLunar lunar)
    {
        return new(lunar.YearGanIndexExact + 1);
    }
    public static Dizhi YearZhiExact(this LLunar lunar)
    {
        return new(lunar.YearZhiIndexExact + 1);
    }

    public static Tiangan YearGanByLiChun(this LLunar lunar)
    {
        return new(lunar.YearGanIndexByLiChun + 1);
    }
    public static Dizhi YearZhiByLiChun(this LLunar lunar)
    {
        return new(lunar.YearZhiIndexByLiChun + 1);
    }

    public static Tiangan MonthGan(this LLunar lunar)
    {
        return new(lunar.MonthGanIndex + 1);
    }
    public static Dizhi MonthZhi(this LLunar lunar)
    {
        return new(lunar.MonthZhiIndex + 1);
    }

    public static Tiangan MonthGanExact(this LLunar lunar)
    {
        return new(lunar.MonthGanIndexExact + 1);
    }
    public static Dizhi MonthZhiExact(this LLunar lunar)
    {
        return new(lunar.MonthZhiIndexExact + 1);
    }


    public static Tiangan DayGan(this LLunar lunar)
    {
        return new(lunar.DayGanIndex + 1);
    }
    public static Dizhi DayZhi(this LLunar lunar)
    {
        return new(lunar.DayZhiIndex + 1);
    }

    public static Tiangan DayGanExact(this LLunar lunar)
    {
        return new(lunar.DayGanIndexExact + 1);
    }
    public static Dizhi DayZhiExact(this LLunar lunar)
    {
        return new(lunar.DayZhiIndexExact + 1);
    }

    public static Tiangan DayGanExact2(this LLunar lunar)
    {
        return new(lunar.DayGanIndexExact2 + 1);
    }
    public static Dizhi DayZhiExact2(this LLunar lunar)
    {
        return new(lunar.DayZhiIndexExact2 + 1);
    }

    public static Tiangan TimeGan(this LLunar lunar)
    {
        return new(lunar.TimeGanIndex + 1);
    }
    public static Dizhi TimeZhi(this LLunar lunar)
    {
        return new(lunar.TimeZhiIndex + 1);
    }
}
