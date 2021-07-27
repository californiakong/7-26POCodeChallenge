using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		int[] arr = new int[] {90, 21, 15, 12, 70, 66, 89, 7};
		int x = 97;
		for (int i = 0; i < arr.Length; i++) {
			int sum = 0;
			for (int j = i; j < arr.Length; j++) {
				sum += arr[j]; 
				if (sum == x) {
					for (int k = i; k<= j; k++) {
						Console.WriteLine(arr[k]);
					}
					return;
				}
			}
		}
		return;
	}
}