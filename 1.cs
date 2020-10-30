//Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
//For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

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
		Console.WriteLine("Enter value of k");
		int k = Convert.ToInt32(Console.ReadLine());
		for(int i = 0; i< size; i++){
		    for(int j = 0; j < size; j++){
		        int sum;
		        if(i == j){
		            continue;
		        }
		        else{
		            sum = arr[i] + arr[j];
		        }
		        if(sum == k){
		            Console.WriteLine("True");
		            return;
		        }
		    } 
		}
		Console.WriteLine("False");
	}
}
