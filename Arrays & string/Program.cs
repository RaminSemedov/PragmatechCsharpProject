//Arrays   & String




using System;

public static class MyString
{

	public static string MySubString(this string text, int start)
	{

		char[] arr = new char[text.Length - start];
		int j = 0;
		for (int i = start; i < text.Length; i++)
		{
			arr[j] = text[i];
			j++;
		}
		string a = new string(arr);
		return a;
	}



	public static bool IsPolindrom(this string text)
	{
		int counter = 0;
		for (int i = 0; i < text.Length / 2; i++)
		{
			if (text[i] == text[text.Length - 1 - i])
			{
				counter++;
			}
		}
		if (counter == text.Length / 2)
		{
			return true;
		}
		return false;
	}

	public static string ReverseText(this string text)
	{
		char[] reversedText = new char[text.Length];
		for (int i = 0; i < text.Length; i++)
		{
			reversedText[i] = text[text.Length - 1 - i];
		}



		return new string(reversedText);
	}

	public static string MyRemoveDublicate(this string text)
	{

		char[] newText = new char[text.Length];
		int counter = 0;


		for (int i = 0; i < text.Length; i++)
		{
			for (int j = 0; j < text.Length; j++)
			{
				if (text[i] == newText[j])
				{
					break;
				}
				if (i == j)
				{
					newText[counter++] = text[i];
				}
			}

		}

		return new string(newText);

	}

    public static int MyIndexOf(this string text, char simbol)
    {

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == simbol)
            {

                return i;
            }         
        }
				return -1;
    }

	public static string MyClone(this string text) {
		return text;
	}
	public static bool MyContains(this string text,char simbol)
    {
        for (int i = 0; i < text.Length; i++)
        {
			if (text[i] == simbol)
				return true;

        }
		return false;
    }
	public static int MyCompareTo(this string text1, string text2) {
        if (text1 == text2)
        {
			return 0; 
        }
		return -1;
	}
	public static bool MyStartsWith(this string text,char simbol)
    {
		if (text[0] == simbol)
			return true;
		return false;
    }
	public static bool MyEndsWith(this string text, char simbol)
	{
		if (text[text.Length-1] == simbol)
			return true;
		return false;
	}
	public static void MyCopyTo(this string text, int sourceIndex, char[] destination, int destinationIndex, int count) {

        for (int i = 0; i < count; i++)
        {
			destination[destinationIndex] = text[sourceIndex];
			destinationIndex++;
			sourceIndex++;



		}
	
	} 


}



public class Program
{
	public static void Main()
	{
		char[] arr = {'a','b','e', 'a', 'b', 'e', 'a', 'b', 'e','r'};
	    "kjdhkdjh kdhs".CopyTo(0,arr,3,5);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);

        }
	}
}