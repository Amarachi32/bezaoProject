/*
1) enter a sentence
2) the program takes first letter of every word to the end of the particular word and append ay to it
3) press any key to convert back to original sentence
*/
internal class Program
{
    private static void Main(string[] args)
    {
        string firstLetter;
        string afterWord;
        string pigLatinWord = "";
        int j;

        Console.WriteLine("Enter a sentence to convert into PigLatin");
        string sentence = Console.ReadLine();

        string[] text = sentence.Split();

        foreach (string word in text)
        {
            afterWord = word.Substring(1);
            firstLetter = word.Substring(0, 1);
            j = sentence.IndexOf(firstLetter);

            pigLatinWord = afterWord + firstLetter + "ay ";

            Console.Write(pigLatinWord);


        }

        Console.WriteLine("Press any key to convert back to sentence.");
        Console.ReadKey(true);
        string clonedString = null;
        clonedString = (string)sentence.Clone();
        Console.WriteLine(clonedString);
    }
}