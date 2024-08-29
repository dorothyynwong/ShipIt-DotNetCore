using System.Data;

namespace ShipIt.Models.DataModels
{
    public class StockCompanyProductDataModel
    {
        public int StockHeld { get; set; }
        public string Gcp { get; set; }
        public string Name { get; set; }
        public string Addr2 { get; set; }
        public string Addr3 { get; set; }
        public string Addr4 { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public int LowerThreshold { get; set; }
        public int Discontinued { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public string Gtin { get; set; }
        public string ProductName { get; set; }

        public StockCompanyProductDataModel(IDataReader dataReader)
        {
            var dataRecord = (IDataRecord)dataReader;
            StockHeld = (int)dataRecord[0];
            Gcp = (string)dataRecord[1];
            Name = (string)dataRecord[2];
            Addr2 = (string)dataRecord[3];
            Addr3 = (string)dataRecord[4];
            Addr4 = (string)dataRecord[5];
            PostalCode = (string)dataRecord[6];
            City = (string)dataRecord[7];
            Tel = (string)dataRecord[8];
            Mail = (string)dataRecord[9];
            LowerThreshold = (int)dataRecord[10];
            Discontinued = (int)dataRecord[11];
            MinimumOrderQuantity = (int)dataRecord[12];
            Gtin = dataRecord[13].ToString();
            ProductName = (string)dataRecord[14];
        }
        
        public StockCompanyProductDataModel() {}
    }
}
