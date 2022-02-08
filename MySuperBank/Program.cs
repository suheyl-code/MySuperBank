using MySuperBank;

var account1 = new BankAccount("John", 10000);
var account2 = new BankAccount("Mirana", 999);

account1.MakeDeposit(1, DateTime.UtcNow,"One dollar Deposit");
account1.MakeWithdrawl(50, DateTime.UtcNow, "Xbox purchase");
Console.WriteLine(account1.GetAccountHistory());
Console.WriteLine(account2.GetAccountHistory());