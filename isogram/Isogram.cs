using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        
        char[] charsInWord = word.ToCharArray();

        for (int i=0; i < word.Length; i++)
        {
            if( Char.IsLetter(charsInWord[i]) && 
                                                 (word.IndexOf(charsInWord[i]) != word.LastIndexOf(charsInWord[i])))

                return false;
        }
        
        return true;

    }
}
