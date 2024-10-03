BankAccount bankAccount = new BankAccount(100);

Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);

Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(20);

Console.WriteLine(bankAccount.GetBalance());