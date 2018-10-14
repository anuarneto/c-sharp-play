using System;
using System.Linq;					
public class Numbers
{
	public static int MostPopularNumber(int[] numbers) 
	{
		return numbers.GroupBy(ii => ii)
        	.OrderByDescending(abc => abc.Count()) 
        	.ThenBy(g => g.Key) 
        	.Select(bcd => bcd.Key)
        	.FirstOrDefault();
	}
}