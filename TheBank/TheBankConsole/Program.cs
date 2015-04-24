using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TheBank.Lib;
using TheBank.Lib.Interfaces;
using TheBank.Lib.enums;

namespace TheBankConsole
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Bank>().As<IBank>();
            builder.RegisterType<AccountOwner>().As<IAccountOwner>();
            Container = builder.Build();

            var scope = Container.BeginLifetimeScope();
            var bank = scope.Resolve<IBank>();
            var owner = scope.Resolve<IAccountOwner>();
            bank.CreateAccount(owner, AccountType.Checking);

            System.Console.WriteLine(owner.GetListOfAccounts().First().Balance.ToString());
            System.Console.ReadLine();
        }
    }
}
