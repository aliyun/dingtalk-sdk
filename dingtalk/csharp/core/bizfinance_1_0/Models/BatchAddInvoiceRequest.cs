// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BatchAddInvoiceRequest : TeaModel {
        /// <summary>
        /// 发票模型
        /// </summary>
        [NameInMap("generalInvoiceVOList")]
        [Validation(Required=false)]
        public List<BatchAddInvoiceRequestGeneralInvoiceVOList> GeneralInvoiceVOList { get; set; }
        public class BatchAddInvoiceRequestGeneralInvoiceVOList : TeaModel {
            /// <summary>
            /// 账期时间
            /// </summary>
            [NameInMap("accountPeriod")]
            [Validation(Required=false)]
            public string AccountPeriod { get; set; }

            /// <summary>
            /// 不含税金额
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// 含税金额
            /// </summary>
            [NameInMap("amountWithTax")]
            [Validation(Required=false)]
            public string AmountWithTax { get; set; }

            /// <summary>
            /// 校验码
            /// </summary>
            [NameInMap("checkCode")]
            [Validation(Required=false)]
            public string CheckCode { get; set; }

            /// <summary>
            /// 查验时间
            /// </summary>
            [NameInMap("checkTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// 开票日期
            /// </summary>
            [NameInMap("drewDate")]
            [Validation(Required=false)]
            public string DrewDate { get; set; }

            /// <summary>
            /// 电票版式文件下载地址
            /// </summary>
            [NameInMap("electronicUrl")]
            [Validation(Required=false)]
            public string ElectronicUrl { get; set; }

            /// <summary>
            /// 财务类型，INPUT-VAT(进项),OUTPUT_VAT(销项)
            /// </summary>
            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }

            /// <summary>
            /// 资金类型 ，RED（红票），（BLUE）蓝票
            /// </summary>
            [NameInMap("fundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            /// <summary>
            /// 常规发票明细
            /// </summary>
            [NameInMap("generalInvoiceDetailVO")]
            [Validation(Required=false)]
            public BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVO GeneralInvoiceDetailVO { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVO : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }
                [NameInMap("goodName")]
                [Validation(Required=false)]
                public string GoodName { get; set; }
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }
                [NameInMap("revenueCode")]
                [Validation(Required=false)]
                public string RevenueCode { get; set; }
                [NameInMap("rowNo")]
                [Validation(Required=false)]
                public string RowNo { get; set; }
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }
                [NameInMap("taxPre")]
                [Validation(Required=false)]
                public string TaxPre { get; set; }
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }
                [NameInMap("unitPrice")]
                [Validation(Required=false)]
                public string UnitPrice { get; set; }
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
            /// 发票类型
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// 机器码
            /// </summary>
            [NameInMap("machineCode")]
            [Validation(Required=false)]
            public string MachineCode { get; set; }

            /// <summary>
            /// 成品油标识
            /// </summary>
            [NameInMap("oilFlag")]
            [Validation(Required=false)]
            public string OilFlag { get; set; }

            /// <summary>
            /// 收款人
            /// </summary>
            [NameInMap("payee")]
            [Validation(Required=false)]
            public string Payee { get; set; }

            /// <summary>
            /// 审批单实例
            /// </summary>
            [NameInMap("processInstCode")]
            [Validation(Required=false)]
            public string ProcessInstCode { get; set; }

            /// <summary>
            /// 审批单类型
            /// </summary>
            [NameInMap("processInstType")]
            [Validation(Required=false)]
            public string ProcessInstType { get; set; }

            /// <summary>
            /// 购方地址
            /// </summary>
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            /// <summary>
            /// 购方银行
            /// </summary>
            [NameInMap("purchaserBankNameAccount")]
            [Validation(Required=false)]
            public string PurchaserBankNameAccount { get; set; }

            /// <summary>
            /// 购方名称
            /// </summary>
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// 购方税号
            /// </summary>
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// 购方电话
            /// </summary>
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

            /// <summary>
            /// 备注
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// 二手车费用明细
            /// </summary>
            [NameInMap("secondHandCarInvoiceDetail")]
            [Validation(Required=false)]
            public BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetail SecondHandCarInvoiceDetail { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetail : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }
                [NameInMap("cardNo")]
                [Validation(Required=false)]
                public string CardNo { get; set; }
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }
                [NameInMap("revenueCode")]
                [Validation(Required=false)]
                public string RevenueCode { get; set; }
                [NameInMap("rowNo")]
                [Validation(Required=false)]
                public string RowNo { get; set; }
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }
            };

            /// <summary>
            /// 销方地址
            /// </summary>
            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }

            /// <summary>
            /// 销方银行
            /// </summary>
            [NameInMap("sellerBankNameAccount")]
            [Validation(Required=false)]
            public string SellerBankNameAccount { get; set; }

            /// <summary>
            /// 销方名称
            /// </summary>
            [NameInMap("sellerName")]
            [Validation(Required=false)]
            public string SellerName { get; set; }

            /// <summary>
            /// 销方税号
            /// </summary>
            [NameInMap("sellerTaxNo")]
            [Validation(Required=false)]
            public string SellerTaxNo { get; set; }

            /// <summary>
            /// 销方电话
            /// </summary>
            [NameInMap("sellerTel")]
            [Validation(Required=false)]
            public string SellerTel { get; set; }

            /// <summary>
            /// 发票状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 代开发票标识 1-自开，2-代开
            /// </summary>
            [NameInMap("supplySign")]
            [Validation(Required=false)]
            public string SupplySign { get; set; }

            /// <summary>
            /// 税额
            /// </summary>
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            /// <summary>
            /// 二手车发票详情
            /// </summary>
            [NameInMap("usedVehicleSaleDetailVO")]
            [Validation(Required=false)]
            public BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVO UsedVehicleSaleDetailVO { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVO : TeaModel {
                [NameInMap("auctionUnit")]
                [Validation(Required=false)]
                public string AuctionUnit { get; set; }
                [NameInMap("auctionUnitAddress")]
                [Validation(Required=false)]
                public string AuctionUnitAddress { get; set; }
                [NameInMap("auctionUnitBank")]
                [Validation(Required=false)]
                public string AuctionUnitBank { get; set; }
                [NameInMap("auctionUnitTaxNo")]
                [Validation(Required=false)]
                public string AuctionUnitTaxNo { get; set; }
                [NameInMap("auctionUtilTel")]
                [Validation(Required=false)]
                public string AuctionUtilTel { get; set; }
                [NameInMap("carModel")]
                [Validation(Required=false)]
                public string CarModel { get; set; }
                [NameInMap("cardNo")]
                [Validation(Required=false)]
                public string CardNo { get; set; }
                [NameInMap("registration")]
                [Validation(Required=false)]
                public string Registration { get; set; }
                [NameInMap("transferVehicle")]
                [Validation(Required=false)]
                public string TransferVehicle { get; set; }
                [NameInMap("usedCarAddress")]
                [Validation(Required=false)]
                public string UsedCarAddress { get; set; }
                [NameInMap("usedCarMarket")]
                [Validation(Required=false)]
                public string UsedCarMarket { get; set; }
                [NameInMap("usedCarMarketBank")]
                [Validation(Required=false)]
                public string UsedCarMarketBank { get; set; }
                [NameInMap("usedCarMarketPhone")]
                [Validation(Required=false)]
                public string UsedCarMarketPhone { get; set; }
                [NameInMap("usedCarMarketTaxNo")]
                [Validation(Required=false)]
                public string UsedCarMarketTaxNo { get; set; }
                [NameInMap("vehicleNo")]
                [Validation(Required=false)]
                public string VehicleNo { get; set; }
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }
            };

            /// <summary>
            /// 车辆售卖发票明细
            /// </summary>
            [NameInMap("vehicleSaleDetailVO")]
            [Validation(Required=false)]
            public BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVO VehicleSaleDetailVO { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVO : TeaModel {
                [NameInMap("brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }
                [NameInMap("certificateNo")]
                [Validation(Required=false)]
                public string CertificateNo { get; set; }
                [NameInMap("engineNo")]
                [Validation(Required=false)]
                public string EngineNo { get; set; }
                [NameInMap("idCardNo")]
                [Validation(Required=false)]
                public string IdCardNo { get; set; }
                [NameInMap("importCertificateNo")]
                [Validation(Required=false)]
                public string ImportCertificateNo { get; set; }
                [NameInMap("inspectionListNo")]
                [Validation(Required=false)]
                public string InspectionListNo { get; set; }
                [NameInMap("maxPassengers")]
                [Validation(Required=false)]
                public string MaxPassengers { get; set; }
                [NameInMap("originPlace")]
                [Validation(Required=false)]
                public string OriginPlace { get; set; }
                [NameInMap("paymentVoucherNo")]
                [Validation(Required=false)]
                public string PaymentVoucherNo { get; set; }
                [NameInMap("taxAuthorityName")]
                [Validation(Required=false)]
                public string TaxAuthorityName { get; set; }
                [NameInMap("taxAuthorityNo")]
                [Validation(Required=false)]
                public string TaxAuthorityNo { get; set; }
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }
                [NameInMap("tonnage")]
                [Validation(Required=false)]
                public string Tonnage { get; set; }
                [NameInMap("vehicleNo")]
                [Validation(Required=false)]
                public string VehicleNo { get; set; }
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }
            };

            /// <summary>
            /// 发票查验状态
            /// </summary>
            [NameInMap("verifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

            /// <summary>
            /// 凭证code
            /// </summary>
            [NameInMap("voucherCode")]
            [Validation(Required=false)]
            public string VoucherCode { get; set; }

            /// <summary>
            /// 生成凭证状态
            /// </summary>
            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }

        }

    }

}
