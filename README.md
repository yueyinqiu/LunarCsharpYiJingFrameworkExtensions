# LunarCsharpYiJingFrameworkExtensions

LunarCsharpYiJingFrameworkExtensions 在 [lunar-csharp](https://www.nuget.org/packages/lunar-csharp) 的基础上提供了一些扩展方法，从而更方便地和 [YiJingFramework](https://github.com/YiJingFramework/YiJingFramework/wiki) 进行对接。

目前这个包的功能还比较简陋，只是为 `Lunar` 和 `EightChar` 类型添加了获取 `Tiangan` 和 `Dizhi` 类型年月日时的扩展方法。

举例而言，我们可以这样使用 lunar-csharp 来获取今年的地支：

```csharp
var lunar = Lunar.Lunar.FromDate(DateTime.Now);
// 这边命名空间和类型同名了，所以只能写全名了。

var yearZhi = lunar.YearZhi;
Console.WriteLine(yearZhi); // 卯（也可能是别的）
Console.WriteLine(yearZhi.GetType()); // System.String
```

可以看到， `lunar.YearZhi` 返回的结果是 `string` 类型的，直接拿来输出比较方便，但如果后面还要做其他操作，可能不是那么好用。

而这个包就是添加了一个同名的扩展方法，于是可以这样使用：

```csharp
using LunarCsharpYiJingFrameworkExtensions;

var lunar = Lunar.Lunar.FromDate(DateTime.Now);
// 这边命名空间和类型同名了，所以只能写全名了。

var yearZhi = lunar.YearZhi();
// YearZhi 后面加一个括号即可。
// 不过 Visual Studio 的自动补全好像不提示这个扩展方法。不太清楚为什么。

Console.WriteLine(yearZhi); // Mao
Console.WriteLine(yearZhi.GetType()); // YiJingFramework.PrimitiveTypes.Dizhi
```

现在我们直接获取到了一个 `Dizhi` 类型的结果，可以借助其他相关的方法或者包来进行操作了。
