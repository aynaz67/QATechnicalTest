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

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] == input[j])
                    return false;
            }
        }

        return true;
    }
}
