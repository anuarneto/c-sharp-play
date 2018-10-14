public class Palindrome
{
	public static bool IsAlmostPalindrome(string value)
	{
		int i = 0;
		int j = value.Length - 1;
		int diffs = 0;
		while (true)
		{
			if (i > j)
			{
				return diffs< 2;
			}
			char a = value[i];
			char b = value[j];
			if (char.ToLower(a) != char.ToLower(b))
			{
				diffs++;
                if (diffs > 1)
                {
                    return false;
                }
			}
			i++;
			j--;
		}
	}
}