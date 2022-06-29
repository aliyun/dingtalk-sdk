// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceIgnoreStatusRequest : TeaModel {
        /// <summary>
        /// 发票全票面信息
        /// </summary>
        [NameInMap("generalInvoiceVO")]
        [Validation(Required=false)]
        public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO GeneralInvoiceVO { get; set; }
        public class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO : TeaModel {
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
            public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList GeneralInvoiceDetailVOList { get; set; }
            public class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList : TeaModel {
                /// <summary>
                /// 金额
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [NameInMap("goodName")]
                [Validation(Required=false)]
                public string GoodName { get; set; }

                /// <summary>
                /// 数量
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public string Quantity { get; set; }

                /// <summary>
                /// 税收分类编码
                /// </summary>
                [NameInMap("revenueCode")]
                [Validation(Required=false)]
                public string RevenueCode { get; set; }

                /// <summary>
                /// 行号
                /// </summary>
                [NameInMap("rowNo")]
                [Validation(Required=false)]
                public string RowNo { get; set; }

                /// <summary>
                /// 规格型号
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// 税额
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// 是否享受税收优惠：0-不享受，1-享受
                /// </summary>
                [NameInMap("taxPre")]
                [Validation(Required=false)]
                public string TaxPre { get; set; }

                /// <summary>
                /// 税率
                /// </summary>
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// 单位
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// 单价
                /// </summary>
                [NameInMap("unitPrice")]
                [Validation(Required=false)]
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
            [NameInMap("secondHandCarInvoiceDetail")]
            [Validation(Required=false)]
            public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetail SecondHandCarInvoiceDetail { get; set; }
            public class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetail : TeaModel {
                /// <summary>
                /// 金额
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// 车牌号
                /// </summary>
                [NameInMap("cardNo")]
                [Validation(Required=false)]
                public string CardNo { get; set; }

                /// <summary>
                /// 通行日期止
                /// </summary>
                [NameInMap("endDate")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

                /// <summary>
                /// 税收分类编码
                /// </summary>
                [NameInMap("revenueCode")]
                [Validation(Required=false)]
                public string RevenueCode { get; set; }

                /// <summary>
                /// 行号
                /// </summary>
                [NameInMap("rowNo")]
                [Validation(Required=false)]
                public string RowNo { get; set; }

                /// <summary>
                /// 通行日期起
                /// </summary>
                [NameInMap("startDate")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// 税额
                /// </summary>
                [NameInMap("taxAmount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// 税率
                /// </summary>
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// 类型
                /// </summary>
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

            }
            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }
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
            [NameInMap("usedVehicleSaleDetailVO")]
            [Validation(Required=false)]
            public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVO UsedVehicleSaleDetailVO { get; set; }
            public class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVO : TeaModel {
                /// <summary>
                /// 经营、拍卖单位
                /// </summary>
                [NameInMap("auctionUnit")]
                [Validation(Required=false)]
                public string AuctionUnit { get; set; }

                /// <summary>
                /// 经营、拍卖单位地址
                /// </summary>
                [NameInMap("auctionUnitAddress")]
                [Validation(Required=false)]
                public string AuctionUnitAddress { get; set; }

                /// <summary>
                /// 经营、拍卖单位银行
                /// </summary>
                [NameInMap("auctionUnitBank")]
                [Validation(Required=false)]
                public string AuctionUnitBank { get; set; }

                /// <summary>
                /// 经营、拍卖单位税号
                /// </summary>
                [NameInMap("auctionUnitTaxNo")]
                [Validation(Required=false)]
                public string AuctionUnitTaxNo { get; set; }

                /// <summary>
                /// 经营、拍卖单位电话
                /// </summary>
                [NameInMap("auctionUtilTel")]
                [Validation(Required=false)]
                public string AuctionUtilTel { get; set; }

                /// <summary>
                /// 厂牌型号
                /// </summary>
                [NameInMap("carModel")]
                [Validation(Required=false)]
                public string CarModel { get; set; }

                /// <summary>
                /// 车牌照号
                /// </summary>
                [NameInMap("cardNo")]
                [Validation(Required=false)]
                public string CardNo { get; set; }

                /// <summary>
                /// 登记证号
                /// </summary>
                [NameInMap("registration")]
                [Validation(Required=false)]
                public string Registration { get; set; }

                /// <summary>
                /// 转入地车辆管理所名称
                /// </summary>
                [NameInMap("transferVehicle")]
                [Validation(Required=false)]
                public string TransferVehicle { get; set; }

                /// <summary>
                /// 二手车市场地址
                /// </summary>
                [NameInMap("usedCarAddress")]
                [Validation(Required=false)]
                public string UsedCarAddress { get; set; }

                /// <summary>
                /// 二手车市场
                /// </summary>
                [NameInMap("usedCarMarket")]
                [Validation(Required=false)]
                public string UsedCarMarket { get; set; }

                /// <summary>
                /// 二手车市场开户银行、账号
                /// </summary>
                [NameInMap("usedCarMarketBank")]
                [Validation(Required=false)]
                public string UsedCarMarketBank { get; set; }

                /// <summary>
                /// 二手车市场电话
                /// </summary>
                [NameInMap("usedCarMarketPhone")]
                [Validation(Required=false)]
                public string UsedCarMarketPhone { get; set; }

                /// <summary>
                /// 二手车市场纳税人识别号
                /// </summary>
                [NameInMap("usedCarMarketTaxNo")]
                [Validation(Required=false)]
                public string UsedCarMarketTaxNo { get; set; }

                /// <summary>
                /// 车架号/车辆识别号
                /// </summary>
                [NameInMap("vehicleNo")]
                [Validation(Required=false)]
                public string VehicleNo { get; set; }

                /// <summary>
                /// 车辆类型
                /// </summary>
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
                public string VehicleType { get; set; }

            }
            [NameInMap("vehicleSaleDetailVO")]
            [Validation(Required=false)]
            public UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVO VehicleSaleDetailVO { get; set; }
            public class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVO : TeaModel {
                /// <summary>
                /// 品牌
                /// </summary>
                [NameInMap("brand")]
                [Validation(Required=false)]
                public string Brand { get; set; }

                /// <summary>
                /// 合格证号
                /// </summary>
                [NameInMap("certificateNo")]
                [Validation(Required=false)]
                public string CertificateNo { get; set; }

                /// <summary>
                /// 发动机号
                /// </summary>
                [NameInMap("engineNo")]
                [Validation(Required=false)]
                public string EngineNo { get; set; }

                /// <summary>
                /// 身份证号/组织机构代码
                /// </summary>
                [NameInMap("idCardNo")]
                [Validation(Required=false)]
                public string IdCardNo { get; set; }

                /// <summary>
                /// 进口证书号
                /// </summary>
                [NameInMap("importCertificateNo")]
                [Validation(Required=false)]
                public string ImportCertificateNo { get; set; }

                /// <summary>
                /// 限乘人数
                /// </summary>
                [NameInMap("maxPassengers")]
                [Validation(Required=false)]
                public string MaxPassengers { get; set; }

                /// <summary>
                /// 产地
                /// </summary>
                [NameInMap("originPlace")]
                [Validation(Required=false)]
                public string OriginPlace { get; set; }

                /// <summary>
                /// 完税凭证号码
                /// </summary>
                [NameInMap("paymentVoucherNo")]
                [Validation(Required=false)]
                public string PaymentVoucherNo { get; set; }

                /// <summary>
                /// 主管税务机关名称
                /// </summary>
                [NameInMap("taxAuthorityName")]
                [Validation(Required=false)]
                public string TaxAuthorityName { get; set; }

                /// <summary>
                /// 主管税务机关代码
                /// </summary>
                [NameInMap("taxAuthorityNo")]
                [Validation(Required=false)]
                public string TaxAuthorityNo { get; set; }

                /// <summary>
                /// 税率
                /// </summary>
                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// 吨位
                /// </summary>
                [NameInMap("tonnage")]
                [Validation(Required=false)]
                public string Tonnage { get; set; }

                /// <summary>
                /// 车架号码
                /// </summary>
                [NameInMap("vehicleNo")]
                [Validation(Required=false)]
                public string VehicleNo { get; set; }

                /// <summary>
                /// 车辆类型
                /// </summary>
                [NameInMap("vehicleType")]
                [Validation(Required=false)]
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
        /// 发票编码
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
        /// 发票状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
