// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetInvoiceByPageResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInvoiceByPageResponseBodyResult Result { get; set; }
        public class GetInvoiceByPageResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public string HasMore { get; set; }
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetInvoiceByPageResponseBodyResultList> List { get; set; }
            public class GetInvoiceByPageResponseBodyResultList : TeaModel {
                public string AccountPeriod { get; set; }
                public string Amount { get; set; }
                public string AmountWithTax { get; set; }
                public string CheckCode { get; set; }
                public string CheckTime { get; set; }
                public string DrewDate { get; set; }
                public string ElectronicUrl { get; set; }
                public string FinanceType { get; set; }
                public string FundType { get; set; }
                public List<GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList : TeaModel {
                    public string Amount { get; set; }
                    public string GoodName { get; set; }
                    public string Quantity { get; set; }
                    public string RevenueCode { get; set; }
                    public string RowNo { get; set; }
                    public string Specification { get; set; }
                    public string TaxAmount { get; set; }
                    public string TaxPre { get; set; }
                    public string TaxRate { get; set; }
                    public string Unit { get; set; }
                    public string UnitPrice { get; set; }
                }
                public string InvoiceCode { get; set; }
                public string InvoiceNo { get; set; }
                public string InvoiceType { get; set; }
                public string MachineCode { get; set; }
                public string OilFlag { get; set; }
                public string Payee { get; set; }
                public string ProcessInstCode { get; set; }
                public string ProcessInstType { get; set; }
                public string PurchaserAddress { get; set; }
                public string PurchaserBankNameAccount { get; set; }
                public string PurchaserName { get; set; }
                public string PurchaserTaxNo { get; set; }
                public string PurchaserTel { get; set; }
                public string Remark { get; set; }
                public string SellerAddress { get; set; }
                public string SellerBankNameAccount { get; set; }
                public string SellerName { get; set; }
                public string SellerTaxNo { get; set; }
                public string SellerTel { get; set; }
                public string Status { get; set; }
                public string SupplySign { get; set; }
                public string TaxAmount { get; set; }
                public List<GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList> TransportFeeDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList : TeaModel {
                    public string Amount { get; set; }
                    public string CardNo { get; set; }
                    public string EndDate { get; set; }
                    public string GoodsName { get; set; }
                    public string RevenueCode { get; set; }
                    public string RowNo { get; set; }
                    public string StartDate { get; set; }
                    public string TaxAmount { get; set; }
                    public string TaxRate { get; set; }
                    public string VehicleType { get; set; }
                }
                public List<GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList : TeaModel {
                    public string AuctionUnit { get; set; }
                    public string AuctionUnitAddress { get; set; }
                    public string AuctionUnitBank { get; set; }
                    public string AuctionUnitTaxNo { get; set; }
                    public string AuctionUtilTel { get; set; }
                    public string CarModel { get; set; }
                    public string CardNo { get; set; }
                    public string Registration { get; set; }
                    public string TransferVehicle { get; set; }
                    public string UsedCarAddress { get; set; }
                    public string UsedCarMarket { get; set; }
                    public string UsedCarMarketBank { get; set; }
                    public string UsedCarMarketPhone { get; set; }
                    public string UsedCarMarketTaxNo { get; set; }
                    public string VehicleNo { get; set; }
                    public string VehicleType { get; set; }
                }
                public List<GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList : TeaModel {
                    public string Brand { get; set; }
                    public string CertificateNo { get; set; }
                    public string EngineNo { get; set; }
                    public string IdCardNo { get; set; }
                    public string ImportCertificateNo { get; set; }
                    public string MaxPassengers { get; set; }
                    public string OriginPlace { get; set; }
                    public string PaymentVoucherNo { get; set; }
                    public string TaxAuthorityName { get; set; }
                    public string TaxAuthorityNo { get; set; }
                    public string TaxRate { get; set; }
                    public string Tonnage { get; set; }
                    public string VehicleNo { get; set; }
                    public string VehicleType { get; set; }
                }
                public string VerifyStatus { get; set; }
                public string VoucherCode { get; set; }
                public string VoucherStatus { get; set; }
            }
            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
