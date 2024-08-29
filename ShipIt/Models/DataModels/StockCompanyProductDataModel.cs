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
            dataReader.Read();
            var dataRecord = (IDataRecord)dataReader;
            this.StockHeld = (int)dataRecord[0];
            this.Gcp = (string)dataRecord[1];
            this.Name = (string)dataRecord[2];
            this.Addr2 = (string)dataRecord[3];
            this.Addr3 = (string)dataRecord[4];
            this.Addr4 = (string)dataRecord[5];
            this.PostalCode = (string)dataRecord[6];
            this.City = (string)dataRecord[7];
            this.Tel = (string)dataRecord[8];
            this.Mail = (string)dataRecord[9];
            this.LowerThreshold = (int)dataRecord[10];
            this.Discontinued = (int)dataRecord[11];
            this.MinimumOrderQuantity = (int)dataRecord[12];
            this.Gtin = dataRecord[13].ToString();
            this.ProductName = (string)dataRecord[14];
        }
        
        public StockCompanyProductDataModel() {}

        // public StockCompanyProductDataModel( reader)
        // {
        //     this.StockHeld = reader.StockHeld;
        //     this.Gcp = reader.Gcp;
        //     this.Name = reader.Name;
        //     this.Addr2 = reader.Addr2;
        //     this.Addr3 = reader.Addr3;
        //     this.Addr4 = reader.Addr4;
        //     this.PostalCode = reader.PostalCode;
        //     this.City = reader.City;
        //     this.Tel = reader.Tel;
        //     this.Mail = reader.Mail;
        //     this.PostalCode = reader.PostalCode;
        //     this.City = reader.City;
        //     this.Tel = reader.Tel;
        //     this.Mail = reader.Mail;
        // }
    }
}

//stock.held  s.hld
                //All fields from company
                //gc.gcp_cd , gc.gln_nm, gc.gln_addr_02, gc.gln_addr_03, gc.gln_addr_04
                //gc.gln_addr_postalcode, gc.gln_addr_city, gc.contact_tel, gc.contact_mail
                //product.LowerThreshold gt.l_th
                //product.Discontinued gt.ds
                //product.MinimumOrderQuantity gt.min_qt
                //product.Gtin gt.gtin_cd
                //product.Name gt.gtin_nm