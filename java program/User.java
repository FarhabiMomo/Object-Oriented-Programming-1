/*
Take two integer inputs from user. First calculate the sum of two then product of two. Finally, print the sum and product of both obtained resluts.


import java.util.Scanner;

class User
{
public static void main(String[]args)
{
 Scanner s=new Scanner(System.in);
 int x=s.nextInt();
 int y=s.nextInt();
 int z=x+y;
 int p=x*y;
 
 System.out.println( "print the sum : "+z+ "print the product : " +p);
 }
 }*/
 
 /*
 
 Ask user to give two double input for length and breadth of a rectangle and print area type casted to int.
 import java.util.Scanner;
 class User{
	 
	 public static void main(String[]args)
	 {
		 Scanner s=new Scanner(System.in);
		 double x=s.nextDouble();
		 double y=s.nextDouble();
		 double r=x+y;
		 double area=x*y;
		 System.out.println(" print the rectangular is : " +r);
		 System.out.println((int)area);
		 
	 }
 }*/
 
 import java.util.Scanner;
 
 class User{
	 public static void main(String[]args)
	 {
		 
		 Scanner s=new Scanner(System.in);
		 String name=s.nextLine();
		 int roll=s.nextInt();
		 String interest=s.nextLine();
		 
		 System.out.println(" hey,my name is " +name+ "and my roll number is " +roll+ ".My field of interest are " + interest+ ".");
		 
	 }
 }
		 