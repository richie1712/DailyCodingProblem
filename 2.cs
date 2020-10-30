//Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
//For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. If our input was [3, 2, 1], the expected output would be [2, 3, 6].

using System;

public class Test
{
	public static void Main()
	{
		Console.WriteLine("Enter size of array");
		int size = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter array elements");
		int[] arr = new int[size];
		for(int i = 0; i < size; i++){
		    arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		int[] new_arr = new int[size];
		for(int i = 0; i< size; i++){
		    int value = 1;
		     for(int j = 0; j < size; j++){
		         if(i == j ){
		             continue;
		         }
		         else{
		             value = value * arr[j];
		         }
		     }
		     new_arr[i] = value;
		}
		for(int i = 0; i < size; i++){
		    Console.WriteLine(new_arr[i]);
		}
	}
}
