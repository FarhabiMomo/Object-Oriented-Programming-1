public class BankAccount
{
private String ownerName;
private int accountNumber;
protected float balance;

public void deposit(float anAmount)
{
if(anAmount>0.0)
balance=balance+anAmount;
}

public void withdraw(float anAmount)
{
if((anAmount>0.0)&&(balance>anAmount))
balance=balance-anAmount;

}

public float getBalance()
{
return balance;
}

}
