

int sum = 0;

for (int i = 1; i < 11; i++)//i-- on sama mis i-1
{
    Console.WriteLine($"i = {i}");
    //kuna see on sõne, siis see i väärtust ei muuda
    //AGA ta kuvab i + 1 väärtuse
    Console.WriteLine($"current total: {sum}");
    sum = sum + i;  
}
Console.WriteLine($"Final total {sum}");
//ta ei kuva sama arvu, mis for tsükli lõpus
