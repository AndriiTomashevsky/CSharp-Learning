using System;

// A simple savings account class.
class SavingsAccount
{
    public double currBalance;
    public static double currInterestRate;

    public SavingsAccount(double balance)
    {
        currBalance = balance;
    }

    // A static constructor!
    static SavingsAccount()
    {
        Console.WriteLine("In static ctor!");
        currInterestRate = 0.04;
    }

    // A static property.
    public static double InterestRate
    {
        get { return currInterestRate; }
        set { currInterestRate = value; }
    }

    // Static members to get/set interest rate.
    public static void SetInterestRate(double newRate)
    {
        currInterestRate = newRate;
    }

    public static double GetInterestRate()
    {
        return currInterestRate;
    }
}