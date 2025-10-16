# Icnet Project
V `./app` je umístěna spustitelná aplikace NactiData.exe.
Případně v `.\IcnetProject\bin\Debug\net8.0\NactiData.exe"` po sestavení.

```bash
PS C:\Users\David\source\repos\IcnetProject> .\app\NactiData.exe 4 2 1
7
8
6
```

V IcnetProject.Tests je umístěn testovací projekt s MSTesty.

## Zadání

Programování:

- Vytvoření Windows aplikace pro příkazový řádek v jazyce C#.
- Aplikace se bude jmenovat NactiData.exe a jejími vstupními parametry jsou 3 čísla.
- Výstupem aplikace jsou po spuštění tři hodnoty, kdy každá je zobrazena na novém řádku: 
	- součet všech 3 čísel,
	- součin všech 3 čísel,
	- součet prvních dvou čísel dělený třetím.

V aplikaci je potřeba ošetřit dvě výjimky:  

- správnost všech tří vstupních parametrů,
- správnost numerických operací.

Úkol prosíme předat ve formě projektu Visual Studio. K řešení lze použít Visual Studio Community Edition (https://visualstudio.microsoft.com/vs/community).


---

## Alternativní řešení:

pro lepší rozšiřitelnost, např. kdyby byla potřeba spočítat více čísel. tak je lepší pracovat s polem
a provádět operace na něm:

```csharp
using System.Globalization;

namespace IcnetProject
{
    internal class Program
    {
        /// <summary>
        /// Main entry point of the application.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Three arguments are required: number1, number2, number3");
                return;
            }

            List<double> numbers = new List<double>();

            try
            {
                numbers = args.Select(arg => double.Parse(arg, CultureInfo.InvariantCulture)).ToList();
            }
            catch (FormatException)
            {
                Console.WriteLine("All arguments must be valid numbers.");
                return;
            }

            double sum = numbers.Sum();
            double product = numbers.Aggregate(1.0, (acc, val) => acc * val);
            double thirdOperation = 0;

            Console.WriteLine(sum);
            Console.WriteLine(product);

            if (numbers[2] == 0)
            {
                Console.WriteLine("Division by zero.");
                return;
            }
            else
            {
                thirdOperation = (numbers[0] + numbers[1]) / numbers[2];
            }

            Console.WriteLine(thirdOperation);
        }
    }
}
```