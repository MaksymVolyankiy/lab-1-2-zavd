using Newtonsoft.Json;

var dict = new Dictionary<string, List<int>>
{
    { "key1", new List<int> { 12, 27, 45 } },
    { "key2", new List<int> { 16, 5 } },
    { "key3", new List<int> { 66, 77, 88, 99 } }
};
var sums = new Dictionary<string, int>();

foreach (var kvp in dict)
{
    sums[kvp.Key] = SumList(kvp.Value);
}
string jsonResult = JsonConvert.SerializeObject(sums, Formatting.Indented);
Console.WriteLine(jsonResult);
static int SumList(List<int> list)
{
int sum = 0;
foreach (int num in list)
{
    sum += num;
}
return sum;
}