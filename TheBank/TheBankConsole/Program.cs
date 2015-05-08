using System;
using System.Linq;
using Autofac;
using TheBank.Lib;
using TheBank.Lib.enums;
using TheBank.Lib.Interfaces;

namespace TheBankConsole
{
    internal class Program
    {
        private static IContainer Container { get; set; }

        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Bank>().As<IBank>();
            builder.RegisterType<AccountOwner>().As<IAccountOwner>();
            Container = builder.Build();

            var scope = Container.BeginLifetimeScope();
            var bank = scope.Resolve<IBank>();
            var owner = scope.Resolve<IAccountOwner>();
            bank.CreateAccount(owner, AccountType.Checking);

            Console.WriteLine(owner.GetListOfAccounts().First().Balance.ToString());
            Console.ReadLine();
        }
    }
}