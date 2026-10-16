/*這裡為你設計 4 道由淺入深的 Array（陣列）練習題。
第 1 關：熱身篇（陣列宣告與存取）
題目：
建立一個長度為 5 的字串陣列，依序放入 5 樣你喜歡的水果（例如：蘋果、香蕉等）。
印出第一樣與最後一樣水果。
把第三樣水果改成「芒果」。
用 for 迴圈把陣列裡的所有水果全部印出來。
重點提示：索引值（Index）是從 0 開始算。
*/

/*string[] fruits = {"蘋果", "香蕉", "芭樂", "蓮霧", "水梨"};
Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[4]);

fruits[2] = "芒果";

for(int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine(fruits[i]);
}*/

/*第 2 關：運算篇（累加與極值）
題目：
有一個現成的整數陣列記錄了一週的每日花費：

int[] expenses = { 120, 85, 250, 60, 310, 150, 90 };
請撰寫程式計算並印出：

本週總花費是多少元？

最高單筆花費是多少元？（提示：宣告一個 int max = expenses[0];，用迴圈逐一比對）*/

/*int[] expenses = { 120, 85, 250, 60, 310, 150, 90 };
int sum = expenses.Sum();
int max = expenses[0];
int min = expenses[0];

for(int i = 0; i < expenses.Length; i++)
{
if(expenses[i] > max)
    {
    max = expenses[i];
    }
}

for(int i = 0; i < expenses.Length; i++)
{
if(expenses[i] < min)
    {
    min = expenses[i];
    }
}

Console.WriteLine($"本週總共花費{sum}元");
Console.WriteLine($"最高單筆花費是{max}元");
Console.WriteLine($"最高單筆花費是{min}元");*/

/*第 3 關：搜尋篇（計數與條件篩選）
題目：
全班 6 位學生的考試成績如下：
int[] scores = { 58, 92, 45, 60, 78, 83 };
請寫程式算出：
及格人數（>= 60 分）有幾人？
不及格人數（< 60 分）有幾人？
請印出所有及格的分數。

int pass_num = 0;
int fail_num = 0;
int[] scores = { 58, 92, 45, 60, 78, 83 };

Console.WriteLine("及格的分數有：");

for(int i = 0; i < scores.Length; i++)
{
    if(scores[i] >= 60)
    {
        pass_num++;
        Console.WriteLine(scores[i]);
    }
    else
    {
        fail_num++;
    }
}

Console.WriteLine($"及格人數為：{pass_num}人");
Console.WriteLine($"不及格人數為：{fail_num}人");*/

/*第 4 關：定位篇（線性搜尋與旗標）
題目：
有一批貨物的編號清單如下：

int[] itemCodes = { 101, 205, 308, 412, 503, 619 };
請寫程式尋找貨物編號 412：

用迴圈檢查陣列中是否有編號 412。

若找到：印出「找到了！它在第 X 個位置（索引值為 Y）」，並立即提早結束迴圈（不要繼續白跑剩下的次數）。

若找完全部都沒有：印出「找不到該貨物編號」。

提示：
提早跳出迴圈可以用關鍵字 break;。
如何知道「找完全部都沒有」？可以宣告一個布林旗標 bool isFound = false;，找到時改為 true，最後根據它的狀態判斷是否印出找不到。*/

int[] itemCodes = { 101, 205, 308, 412, 503, 619 };
bool isFound = false;

for(int i = 0; i < itemCodes.Length; i++)
{
    if(itemCodes[i] ==   412)
    {
        Console.WriteLine($"找到了!他在第{i + 1}個位置");
        isFound = true;
        break;
    }
}
if(!isFound)
Console.WriteLine("找不到該貨物編號");