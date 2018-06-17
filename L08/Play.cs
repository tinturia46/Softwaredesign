using System;

namespace L08
{
    public class Play
    {
        public static void waiting()
        {
            Console.WriteLine("Give me ad Position (e.g 9 will put an X in position 9)");
        }
        public void Main(string[] args)
        {
             int input = Convert.ToInt32(Console.ReadLine());
            

            
        switch (input)
        {
            case 1:
                Field.row2[1] = ChoosePlayer.choice;
                Field.createfield();
                break;
           /* case "2":
                Field.row2[2] = ChoosePlayer.choice;
                break;
            case "3":
                Field.row2[3] = ChoosePlayer.choice;
                break;
            case "4":
                Field.row3[1] = ChoosePlayer.choice;
                break;
            case "5":
                Field.row3[2] = ChoosePlayer.choice;
                break;
            case "6":
                Field.row3[3] = ChoosePlayer.choice;
                break;
            case "7":
                Field.row4[1] = ChoosePlayer.choice;
                break;
            case "8":
                Field.row4[2] = ChoosePlayer.choice;
                break;
            case "9":
                Field.row4[3] = ChoosePlayer.choice;
                break;*/
            default:
            Console.WriteLine("Wrong input, Try Again");
            Console.ReadLine();
            break;
        }

        }


    }
}
