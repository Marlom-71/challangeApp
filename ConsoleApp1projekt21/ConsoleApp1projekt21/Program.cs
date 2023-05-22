int numer = 47694852;
string numerASstring = numer.ToString();
char[] letters = numerASstring.ToArray();
int countner0 = 0;
int countner1 = 0;
int countner2 = 0;
int countner3 = 0;
int countner4 = 0;
int countner5 = 0;
int countner6 = 0;
int countner7 = 0;
int countner8 = 0;
int countner9 = 0;
foreach (char letter in letters)
{
    if (letter == '0')
    {

        countner0++;
    }
    else if (letter == '1')
    {
        countner1++;
    }
    {
        if (letter == '2')
        {
            countner2++;
        }
        else if (letter == '3')
        {
            countner3++;
        }
        {
            if (letter == '4')
            {
                countner4++;
            }
            else if (letter == '5')
            {
                countner5++;
            }
            {
                if (letter == '6')
                {
                    countner6++;
                }
                else if (letter == '7')
                {
                    countner7++;
                }
                {
                    if (letter == '8')
                    {
                        countner8++;
                    }
                    else if (letter == '9')
                    {
                        countner9++;
                    }
                }
            }
        }
    }
}
                        Console.WriteLine("0 =>" + countner0);
                        Console.WriteLine("1 =>" + countner1);
                        Console.WriteLine("2 =>" + countner2);
                        Console.WriteLine("3 =>" + countner3);
                        Console.WriteLine("4 =>" + countner4);
                        Console.WriteLine("5 =>" + countner5);
                        Console.WriteLine("6 =>" + countner6);
                        Console.WriteLine("7 =>" + countner7);
                        Console.WriteLine("8 =>" + countner8);
                        Console.WriteLine("9 =>" + countner9);
                 

   