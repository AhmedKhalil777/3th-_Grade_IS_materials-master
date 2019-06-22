using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = {8,2,6,4,5,3,7,1};

            ////Checking first 2 Methods
            //
             //printarray(x);
             //System.Console.WriteLine("====================Reverse=========================");
             //var z = reversearray(x);
             //printarray(z);
            


             // Checjing second 2 methods
            // int s =4 , l =9;
          // System.Console.WriteLine($"Is {s} here : {Ishere(x,s)}");
          // System.Console.WriteLine($"Is {l} here : {Ishere(x,l)}");
            // System.Console.WriteLine("====================Sort=========================");

          // var t = sortarray(x);
          //
          // printarray(t);

          //Fibonacci();

     //Console.WriteLine("Please enter a number");
    //int number = Convert.ToInt32(Console.ReadLine());
   // Console.WriteLine(" #" + Fibonacci(number));

   //for loop factorial\
  // System.Console.WriteLine("Factorial For loop");
   //factorial();
   //System.Console.WriteLine("factorial recursion");
   //// Recursive factorial
   //System.Console.WriteLine($"Factorial of {6} is :{factorial(6)}");
   alphabitsTriangle();
    
        }





  #region Printing Array
        static void printarray(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                System.Console.WriteLine($"element {i+1} is : {x[i]}");
            }
          
        }
#endregion

# region ReverseArray
        static int[] reversearray(int[] x)
        {
              int[] y = new int [x.Length];
              for (int i = x.Length-1 , j =0; i >= 0 ; i--, j++)
              {
                  y[i] = x[j];

              }
              return y;
        }
#endregion

#region  IS here finding an item in array
 static bool Ishere(int[] x , int y){

     foreach (var item in x)
     {
         if (item == y)
             return true;
     }
     return false;

 }


#endregion

#region sorting Array
   static int[] sortarray(int[] arr){
       int temp;
        // traverse 0 to array length 
        for (int i = 0; i < arr.Length - 1; i++) 
  
            // traverse i+1 to array length 
            for (int j = i + 1; j < arr.Length; j++) 
  
                // compare array element with  
                // all next element 
                if (arr[i] < arr[j]) { 
  
                    temp = arr[i]; 
                    arr[i] = arr[j]; 
                    arr[j] = temp; 
                } 
                
                return arr;
                }
#endregion

#region Fibonacci Series  for loop method
static void Fibonacci(){
         int n1=0,n2=1,n3,i,number;    
         Console.Write("Enter the number of elements: ");    
         number = int.Parse(Console.ReadLine());  
         Console.Write(n1+" "+n2+" "); //printing 0 and 1    
         for(i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
         {    
          n3=n1+n2;    
          Console.Write(n3+" ");    
          n1=n2;    
          n2=n3;    
         }   
}
#endregion

#region Fibonacci Series  recursion
static int Fibonacci(int number)
{
    if (number <= 1)
    {
        return 1;
    }
    else
    {
        return Fibonacci(number - 2) + Fibonacci(number - 1);
    }
}
#endregion

#region  Factorial for loop
static void factorial(){
       int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);  
       }  

  #endregion


#region  Factorial Recursion
static  int  factorial(int x)
{
    if (x==1)
    return 1;

    else
    return x * factorial(x-1);
}
#endregion

#region 
static void alphabitsTriangle()
{
    System.Console.WriteLine("+++++++++++++++++++Hello World++++++++++++++++++++++++++");
           char ch='A';      
       int i, j, k, m;      
       for(i=1; i<=26; i++)      
       {      
        for(j=26; j>=i; j--)      
         Console.Write(" ");  

        for(k=1;k<=i;k++)      
         Console.Write(ch++); 

        ch--;      

        for(m=1;m<i;m++)      
         Console.Write(--ch);   

        Console.Write("\n");      
        ch='A'; 
         }    

}
#endregion

    }
   


}