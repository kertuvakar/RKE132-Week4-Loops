
//mäng kestab niikaua, kui me arvame arvuti numbri ära
//while tsüklit kasutatakse, kui me ei tea, mitu korda tsükkel peab kestma
Random rnd = new Random();
int cpuRandom;//tarkvara kuvab arvuti genereeritud juhusliku numbri

bool loopactive = true; 

while (loopactive)
{
cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");
int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber ==cpuRandom) 
        { 
             Console.WriteLine("Good, you won!");//kui ma olen võitnud, siis tahaks rakendusest lahkuda
                                                 //loopactive = false; //Kui ma võidan, siis muutuja loopActive väärtus muutub false.
                                                 //kuna loopActive ei ole enam true, siis while loopi ei rakendada
        break; //kui ma oleen võitnud, lõpetatakse while loop
        }else
        {
            Console.WriteLine("Try again!");
        }
}
Console.WriteLine("Have a nice day!");