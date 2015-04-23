using System;

namespace TheBank.Lib.BankingOperations
{
    public enum TransferState
    {
        Initiated = 0,
        Posted = 1,
        Suspended = 2,
        Canceled = 3
    }

    public class TransferModel
    {
        public int Id { get; set; }
        public Account From { get; set; }
        public Account To { get; set; }
        public double Amount { get; set; }
        public DateTime InitiationDate { get; set; }
        public int Status { get; set; }
    }
}
