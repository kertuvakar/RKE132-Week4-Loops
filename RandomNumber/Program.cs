

Random rnd = new Random();

int myRandomNum; //deklareerin muutuja siin
int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); //genereerib juhusliku arvu nullist kümneni
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");