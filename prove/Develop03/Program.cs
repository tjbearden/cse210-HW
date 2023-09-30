
using System;
// attempt at multiple choices of scriptures to memorize. 
class Program
{
    static void Main(string[] args)
    {
       string MENU = "1. Moses 1:39 \n 2. 2 Nephi 2:25 \n 3. Moroni 10:4-5 \n Please, choose a scipture to memorize: ";
       Console.WriteLine(MENU);
       int userInput = int.Parse(Console.ReadLine());
       switch (userInput)
       {
            case 1:
                String text = "39. For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";
                Scripture scripture1 = new Scripture(text);
                Reference reference1 = new Reference("Moses",1,39);
                UserInterface(scripture1,reference1);
                break;

            case 2:
                text = "27. Adam fell that men might be; and men are, that they might have joy.";
                Scripture scripture2 = new Scripture(text);
                Reference reference2 = new Reference("2 Nephi",2,27);
                UserInterface(scripture2,reference2);
                break;
            case 3:
                text = "4. And when ye shall recieve these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. 5 And by the power of the Holy Ghost ye may know the truth of all things.";
                Scripture scripture3 = new Scripture(text);
                Reference reference3 = new Reference("Moroni",10,4,5);
                UserInterface(scripture3,reference3);
                break;
       }
    }

    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInpute = "";
        while (userInpute.ToUpper() != "QUIT")
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press ENTER to hide more words or type QUIT to end the program.");
            userInpute = Console.ReadLine();
            scripture.HideWords();
            if (scripture.ISCompletelyHidden());
            {
                break;
            }
        }
    }
}