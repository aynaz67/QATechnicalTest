using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(HasOnlyUniqueCharacters("hello")); 
        Console.WriteLine(HasOnlyUniqueCharacters("world")); 
        Console.WriteLine(HasOnlyUniqueCharacters("Adam"));
    }

    static bool HasOnlyUniqueCharacters(string input)
    {
        input = input.ToLower();
        char[] chars = input.ToCharArray();
        Array.Sort(chars);

        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == chars[i - 1])
                return false;
        }
        return true;
    }
}
