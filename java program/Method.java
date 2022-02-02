import java.util.Scanner;

class Method
{

public static void Sum()
{

Scanner s=new Scanner(System.in);
System.out.println("the 1st number is " );
int x=s.nextInt();
System.out.println("the 2nd number is " );
int y=s.nextInt();
int sum=x+y;
System.out.println("the result is " +sum);

}

public static void main(String[]args)
{
Sum();

}
}



