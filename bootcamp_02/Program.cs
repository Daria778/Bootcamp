using System.Diagnostics;
//int[] array = ArrayCreator.Create(10);
int[] array = 100_000_000.Create()
                .Fill(1, 10);
                



int m = 10_000;
int max;
Stopwatch sw = new Stopwatch();
sw.Start();
max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds}");

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");
//Console.WriteLine(array.ConvertToString());