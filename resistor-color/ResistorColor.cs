using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        // throw new NotImplementedException("You need to implement this function.");
        
        switch (color.ToLower())
        {
            case "black" :
                return 0;
                break;

            case "brown" :
                return 1;
                break;

            case "red" :
                return 2;
                break;

            case "orange" :
                return 3;
                break;

            case "yellow" :
                return 4;
                break;

            case "green" :
                return 5;
                break;

            case "blue" :
                return 6;
                break;

            case "violet" :
                return 7;
                break;

            case "grey" :
                return 8;
                break;

            case "white" :
                return 9;
                break;

            // No Default Expected
            default:
                return 10;
                break;

            
        }

    }

    public static string[] Colors()
    {
        //throw new NotImplementedException("You need to implement this function.");
        string[] colors = new string[10];
        colors[0] = "Black";
        colors[1] = "Brown";
        colors[2] = "Red";
        colors[3] = "Orange";
        colors[4] = "Yellow";
        colors[5] = "Green";
        colors[6] = "Blue";
        colors[7] = "Violet";
        colors[8] = "Grey";
        colors[9] = "White";

 
        return colors;
    }
}