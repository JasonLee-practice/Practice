Console.Write("請輸入猜測的數字：");
string input = Console.ReadLine();

// 轉換成功回傳 true，同時將數值寫入新宣告的 guess 變數
if (int.TryParse(input, out int guess))
{
    Console.WriteLine($"轉換成功！你輸入的數字是：{guess}");
}
else
{
    Console.WriteLine("輸入無效！請確保輸入的是整數。");
}