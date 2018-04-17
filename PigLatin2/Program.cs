using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What's the word?");
        string word = Console.ReadLine().ToLower();
        Console.WriteLine(TranslateWord(word));
        Console.WriteLine("Would you like to pick a new word?");

        string newWord = Console.ReadLine().ToLower();
        if (newWord == "yes")
        {
            Main();
        }
        else if (newWord == "no")
        {
            Console.WriteLine("Thank you for using my Pig Latin simulator!");
        }
        else
        {
            Console.WriteLine("I'm sorry, I didn't understand your answer. Please try again." +
                " Yes or No");
            newWord = Console.ReadLine().ToLower();
        }
    }

    public static string TranslateWord(string word)
    {
        var vowelIndex = -1;

        if ((word.IndexOf('a') > -1 && word.IndexOf('a') < vowelIndex) || vowelIndex == -1)
        {
            vowelIndex = word.IndexOf('a');
        }

        if ((word.IndexOf('e') > -1 && word.IndexOf('e') < vowelIndex) || vowelIndex == -1)
        {
            vowelIndex = word.IndexOf('e');
        }

        if ((word.IndexOf('i') > -1 && word.IndexOf('i') < vowelIndex) || vowelIndex == -1)
        {
            vowelIndex = word.IndexOf('i');
        }

        if ((word.IndexOf('o') > -1 && word.IndexOf('o') < vowelIndex) || vowelIndex == -1)
        {
            vowelIndex = word.IndexOf('o');
        }

        if ((word.IndexOf('u') > -1 && word.IndexOf('u') < vowelIndex) || vowelIndex == -1)
        {
            vowelIndex = word.IndexOf('u');
        }

        if (vowelIndex == 0)
        {
            return word + "ay";
        }

        string firstPart = word.Substring(0, vowelIndex);
        string restWord = word.Substring(vowelIndex);
        //string newWord = restWord + firstPart + "ay";
        //word = newWord;
        return restWord + firstPart + "ay";
    }
}
