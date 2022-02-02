public class OverdrafAccount extends BankAccount
{
private float limit;

public void withdraw(float anAmount)
{
if((anAmount>0.0)&&(getBalance()+limit>anAmount))
balance=balance-anAmount;

}
}