int ans = 33;
int limit = 5;
int guess_count = 0;
int guess;
bool win = false;

do
{
Console.WriteLine("請輸入數字");

    while(!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.WriteLine("偵測為非數字，請重新輸入純整數");
    }

    if(guess > ans)
    {
        guess_count++;
        Console.WriteLine($"太大了，還可以猜{limit - guess_count}次");
    }
   else if(guess < ans)
    {
        guess_count++;
        Console.WriteLine($"太小了，還可以猜{limit - guess_count}次");
    }
    else
    {
        Console.WriteLine("你贏啦~");
        win = true;
    }
}
while(guess != ans && guess_count < limit);

if(!win)
{
    Console.WriteLine($"你輸了~正確答案是{ans}");
}