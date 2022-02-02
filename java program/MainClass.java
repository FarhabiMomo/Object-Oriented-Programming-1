public class MainClass
{
public static void main (String[]args)
{
  OverdrafAccount m=new OverdrafAccount();
 m.deposit(1000);
m.withdraw(3083);
System.out.println(m.getBalance());
}
} 