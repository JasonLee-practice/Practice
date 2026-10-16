//基本計算機
int num1;
int num2;

Console.Write("請輸入第一個數：");
while(!int.TryParse(Console.ReadLine(), out num1))
{
    Console.WriteLine("格式錯誤，請重新輸入。");
}
Console.WriteLine($"成功取得第一位數：{num1}");

Console.Write("請輸入第二個數：");
while(!int.TryParse(Console.ReadLine(), out num2))
{
    Console.WriteLine("格式錯誤，請重新輸入。");
}
Console.WriteLine($"成功取得第二位數：{num2}");

Console.WriteLine($"您輸入的值加總為{num1 + num2}");