namespace ConsoleAPP_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("Xoş gəlmisiniz!");
                Console.WriteLine("1. Yeni hesab yarat");
                Console.WriteLine("2. Pul yatır");
                Console.WriteLine("3. Pul çıxart");
                Console.WriteLine("4. Bütün hesabların siyahısı");
                Console.WriteLine("5. Hesablar arası pul köçürmə");
                Console.WriteLine("0. Çıxış");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            bank.CreateAccount();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            var allAccounts = bank.GetAllAccounts();
                            foreach (var account in allAccounts)
                            {
                                Console.WriteLine($"Hesab ID: {account.AccountId}, Balans: {account.Balance}");
                            }
                            break;
                        case 5:
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Yanlış seçim formatı.");
                }

            }
        }
    }
}