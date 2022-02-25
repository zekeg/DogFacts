using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dogfacts
{
    public static void Main()
    {
        string dogName = "Crispy";
        int dogAge = 25;
        char favoriteLetter = 'b';
        bool favoriteBool = false;
        double footLength = 3.555;
        decimal nailHeight = 3324234256.34323422453456M;
        Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old.\nHe scares me because he is constantly yelling his favorite letter which is {favoriteLetter}.\nI think he's gonna get me but he says this is {favoriteBool}.\nHe is very disproportionate his feet are {footLength} inches wide and his nails are {nailHeight} cm tall");

    }
}
