using PP_Oppgave;
using System.Net.Http.Headers;

var Terje = new Terje();
var Bjørnar = new Bjørnar();
var Franz = new Franz();

valg();
void valg()
{
Console.WriteLine("Terje Bjørnar Franz");
var input = Console.ReadLine();

    switch (input)
    {
        case "Terje":
            Terje.Show();
            WhatToDo();
            break;
        case "Bjørnar":
            Bjørnar.Show();
            WhatToDo2();
            break;
        case "Franz":
            Franz.Show();
            WhatToDo3();
            break;
        default:
            Console.WriteLine("Feil valg");
            break;
    }
        void WhatToDo()
        {
            Console.WriteLine("Hva vil du gjøre?");
            var UserInput = Console.ReadLine();

            if (UserInput == "Sult")
            {
                Terje.Sult++;
                Franz.Sult--;
                Bjørnar.Sult--;
                Console.WriteLine(Terje.Sult);
                Console.WriteLine("Du matet Terje");
                WhatToDo();
            } 
            else if (UserInput == "Entertainment")
            {
            Terje.Entertainment++;
            Franz.Entertainment--;
            Bjørnar.Entertainment--;
            Console.WriteLine(Terje.Entertainment);
                Console.WriteLine("Terje har det gøy");
                WhatToDo();
            }
            else if (UserInput == "Thirst")
            {
            Terje.Thirst++;
            Franz.Thirst--;
            Bjørnar.Thirst--;
            Console.WriteLine(Terje.Thirst);
                Console.WriteLine("Du vannet Terje");
                WhatToDo();
            }
            else if(UserInput == "valg")
            {
                valg();
            }
            else if (UserInput == "stats")
            {
                Console.WriteLine(Terje.Sult);
                Console.WriteLine(Terje.Entertainment);
                Console.WriteLine(Terje.Thirst);
                Console.WriteLine(Bjørnar.Sult);
                Console.WriteLine(Bjørnar.Entertainment);
                Console.WriteLine(Bjørnar.Thirst);
                Console.WriteLine(Franz.Sult);
                Console.WriteLine(Franz.Entertainment);
                Console.WriteLine(Franz.Thirst);
                WhatToDo();
            }
        else
            {
                Console.WriteLine("FEIL VALG!!!!");
                WhatToDo();
            }
        }
    void WhatToDo2()
    {
        Console.WriteLine("Hva vil du gjøre?");
        var UserInput = Console.ReadLine();

        if (UserInput == "Sult")
        {
            Bjørnar.Sult++; 
            Terje.Sult--;
            Franz.Sult--;
            Console.WriteLine(Bjørnar.Sult);
            Console.WriteLine("Du matet Bjørnar");
            WhatToDo2();
        }
        else if (UserInput == "Entertainment")
        {
            Bjørnar.Entertainment++;
            Terje.Entertainment--;
            Franz.Entertainment--;
            Console.WriteLine(Bjørnar.Entertainment);
            Console.WriteLine("Bjørnar har det gøy");
            WhatToDo2();
        }
        else if (UserInput == "Thirst")
        {
            Bjørnar.Thirst++;
            Terje.Thirst--;
            Franz.Thirst--; ;
            Console.WriteLine(Bjørnar.Thirst);
            Console.WriteLine("Du vannet Bjørnar");
            WhatToDo2();
        }
        else if (UserInput == "valg")
        {
            valg();
        }
        else if (UserInput == "stats")
        {
            Console.WriteLine(Terje.Sult);
            Console.WriteLine(Terje.Entertainment);
            Console.WriteLine(Terje.Thirst);
            Console.WriteLine(Bjørnar.Sult);
            Console.WriteLine(Bjørnar.Entertainment);
            Console.WriteLine(Bjørnar.Thirst);
            Console.WriteLine(Franz.Sult);
            Console.WriteLine(Franz.Entertainment);
            Console.WriteLine(Franz.Thirst);
            WhatToDo2();
        }
        else
        {
            Console.WriteLine("FEIL VALG!!!!");
            WhatToDo2();
        }
    }
    void WhatToDo3()
    {
        Console.WriteLine("Hva vil du gjøre?");
        var UserInput = Console.ReadLine();

        if (UserInput == "Sult")
        {
            Bjørnar.Sult--;
            Terje.Sult--;
            Franz.Sult++;
            Console.WriteLine(Franz.Sult);
            Console.WriteLine("Du matet Franz");
            WhatToDo3();
        }
        else if (UserInput == "Entertainment")
        {
            Bjørnar.Entertainment--;
            Terje.Entertainment--;
            Franz.Entertainment++;
            Console.WriteLine(Franz.Entertainment);
            Console.WriteLine("Franz har det gøy");
            WhatToDo3();
        }
        else if (UserInput == "Thirst")
        {
            Bjørnar.Thirst--;
            Terje.Thirst--;
            Franz.Thirst++;
            Console.WriteLine(Franz.Thirst);
            Console.WriteLine("Du vannet Franz");
            WhatToDo3();
        }
        else if (UserInput == "valg")
        {
            valg();
        }
        else if (UserInput == "stats")
        {
            Console.WriteLine(Terje.Sult);
            Console.WriteLine(Terje.Entertainment);
            Console.WriteLine(Terje.Thirst);
            Console.WriteLine(Bjørnar.Sult);
            Console.WriteLine(Bjørnar.Entertainment);
            Console.WriteLine(Bjørnar.Thirst);
            Console.WriteLine(Franz.Sult);
            Console.WriteLine(Franz.Entertainment);
            Console.WriteLine(Franz.Thirst);
            WhatToDo3();
        }
        else
        {
            Console.WriteLine("FEIL VALG!!!!");
            WhatToDo3();
        }
    }
}

