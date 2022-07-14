// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAndReceiptRelatedRequest : TeaModel {
        /// <summary>
        /// 发票全票面信息
        /// </summary>
        [NameInMap("generalInvoiceVO")]
        [Validation(Required=false)]
        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO GeneralInvoiceVO { get; set; }
        public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO : TeaModel {
            [NameInMap("accountPeriod")]
            [Validation(Required=false)]
            public string AccountPeriod { get; set; }
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }
            [NameInMap("amountWithTax")]
            [Validation(Required=false)]
            public string AmountWithTax { get; set; }
            [NameInMap("checkCode")]
            [Validation(Required=false)]
            public string CheckCode { get; set; }
            [NameInMap("checkTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }
            [NameInMap("drewDate")]
            [Validation(Required=false)]
            public string DrewDate { get; set; }
            [NameInMap("electronicUrl")]
            [Validation(Required=false)]
            public string ElectronicUrl { get; set; }
            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }
            [NameInMap("fundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }
            [NameInMap("generalInvoiceDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList : TeaModel {
                public string Amount { get; set; }
                public string GoodName { get; set; }
                public string Quantity { get; set; }
                public string RevenueCode { get; set; }
                public string RowNo { get; set; }
                public string Specification { get; set; }
                public string TaxAmount { get; set; }
                public string TaxPre { get; set; }
                public string TaxPreType { get; set; }
                public string TaxRate { get; set; }
                public string Unit { get; set; }
                public string UnitPrice { get; set; }
            }
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }
            [NameInMap("machineCode")]
            [Validation(Required=false)]
            public string MachineCode { get; set; }
            [NameInMap("oilFlag")]
            [Validation(Required=false)]
            public string OilFlag { get; set; }
            [NameInMap("payee")]
            [Validation(Required=false)]
            public string Payee { get; set; }
            [NameInMap("processInstCode")]
            [Validation(Required=false)]
            public string ProcessInstCode { get; set; }
            [NameInMap("processInstType")]
            [Validation(Required=false)]
            public string ProcessInstType { get; set; }
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }
            [NameInMap("purchaserBankAccount")]
            [Validation(Required=false)]
            public string PurchaserBankAccount { get; set; }
            [NameInMap("purchaserBankNameAccount")]
            [Validation(Required=false)]
            public string PurchaserBankNameAccount { get; set; }
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }
            [NameInMap("secondHandCarInvoiceDetailList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> SecondHandCarInvoiceDetailList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList : TeaModel {
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
            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }
            [NameInMap("sellerBankAccount")]
            [Validation(Required=false)]
            public string SellerBankAccount { get; set; }
            [NameInMap("sellerBankNameAccount")]
            [Validation(Required=false)]
            public string SellerBankNameAccount { get; set; }
            [NameInMap("sellerName")]
            [Validation(Required=false)]
            public string SellerName { get; set; }
            [NameInMap("sellerTaxNo")]
            [Validation(Required=false)]
            public string SellerTaxNo { get; set; }
            [NameInMap("sellerTel")]
            [Validation(Required=false)]
            public string SellerTel { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("supplySign")]
            [Validation(Required=false)]
            public string SupplySign { get; set; }
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }
            [NameInMap("usedVehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList : TeaModel {
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
            [NameInMap("vehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList : TeaModel {
                public string Brand { get; set; }
                public string CertificateNo { get; set; }
                public string EngineNo { get; set; }
                public string IdCardNo { get; set; }
                public string ImportCertificateNo { get; set; }
                public string InspectionListNo { get; set; }
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
            [NameInMap("verifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }
            [NameInMap("voucherCode")]
            [Validation(Required=false)]
            public string VoucherCode { get; set; }
            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }
        };

        /// <summary>
        /// 发票代码
        /// </summary>
        [NameInMap("invoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [NameInMap("invoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 钉钉审批单号
        /// </summary>
        [NameInMap("receiptCode")]
        [Validation(Required=false)]
        public string ReceiptCode { get; set; }

    }

}
