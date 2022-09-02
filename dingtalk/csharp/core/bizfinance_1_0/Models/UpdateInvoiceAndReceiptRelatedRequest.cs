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
            [NameInMap("generalInvoiceDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList : TeaModel {
                /// <summary>
                /// 金额
                /// </summary>
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                /// <summary>
                /// 商品名称
                /// </summary>
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

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
                /// 优惠政策类型
                /// </summary>
                [NameInMap("taxPreType")]
                [Validation(Required=false)]
                public string TaxPreType { get; set; }

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
            /// 发票状态
            /// </summary>
            [NameInMap("invoiceStatus")]
            [Validation(Required=false)]
            public string InvoiceStatus { get; set; }

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
            /// 购方银行账户
            /// 
            /// </summary>
            [NameInMap("purchaserBankAccount")]
            [Validation(Required=false)]
            public string PurchaserBankAccount { get; set; }

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

            [NameInMap("secondHandCarInvoiceDetailList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> SecondHandCarInvoiceDetailList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList : TeaModel {
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

            /// <summary>
            /// 销方地址
            /// </summary>
            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }

            /// <summary>
            /// 销方银行账户
            /// </summary>
            [NameInMap("sellerBankAccount")]
            [Validation(Required=false)]
            public string SellerBankAccount { get; set; }

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

            [NameInMap("usedVehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList : TeaModel {
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

            [NameInMap("vehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList : TeaModel {
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
                /// 商检单号
                /// </summary>
                [NameInMap("inspectionListNo")]
                [Validation(Required=false)]
                public string InspectionListNo { get; set; }

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
        /// 操作员
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 钉钉审批单号
        /// </summary>
        [NameInMap("receiptCode")]
        [Validation(Required=false)]
        public string ReceiptCode { get; set; }

    }

}
