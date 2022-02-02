import java.util.*;

class Array
{
public static void main(String[]args)
{
Scanner s=new Scanner(System.in);
int[] z=new int[10];
for(int i=0;i<z.length;i++)
{
System.out.println("print the value of z["+i+"]");
z[i]=s.nextInt();
}

for(int i=0;i<z.length;i++)
{
System.out.println("the value of z ["+i+"] is "+z[i]);
}
}
}

