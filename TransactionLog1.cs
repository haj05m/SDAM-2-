namespace SDAM_2_Individual_assignment
{
    internal class TransactionLog
    {
        public DateTime DateTime { get; set; }
        public string Action { get; set; }
        public string StockCode { get; set; }
        public string StockItemName { get; set; }
        public int QuantityChanged { get; set; }
    }
}