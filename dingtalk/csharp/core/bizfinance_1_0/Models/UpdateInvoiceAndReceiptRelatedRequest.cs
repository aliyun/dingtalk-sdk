// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateInvoiceAndReceiptRelatedRequest : TeaModel {
        [NameInMap("generalInvoiceVO")]
        [Validation(Required=false)]
        public UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO GeneralInvoiceVO { get; set; }
        public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO : TeaModel {
            [NameInMap("accountPeriod")]
            [Validation(Required=false)]
            public string AccountPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ABC</para>
            /// </summary>
            [NameInMap("agentCode")]
            [Validation(Required=false)]
            public string AgentCode { get; set; }

            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("amountWithTax")]
            [Validation(Required=false)]
            public string AmountWithTax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("caacDevelopmentFund")]
            [Validation(Required=false)]
            public string CaacDevelopmentFund { get; set; }

            [NameInMap("checkCode")]
            [Validation(Required=false)]
            public string CheckCode { get; set; }

            [NameInMap("checkTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123KM</para>
            /// </summary>
            [NameInMap("distance")]
            [Validation(Required=false)]
            public string Distance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("drawerName")]
            [Validation(Required=false)]
            public string DrawerName { get; set; }

            [NameInMap("drewDate")]
            [Validation(Required=false)]
            public string DrewDate { get; set; }

            [NameInMap("electronicUrl")]
            [Validation(Required=false)]
            public string ElectronicUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州北</para>
            /// </summary>
            [NameInMap("entrance")]
            [Validation(Required=false)]
            public string Entrance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州北</para>
            /// </summary>
            [NameInMap("exit")]
            [Validation(Required=false)]
            public string Exit { get; set; }

            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }

            [NameInMap("flightItineraryDetails")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails> FlightItineraryDetails { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>北京国际机场</para>
                /// </summary>
                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AA1234</para>
                /// </summary>
                [NameInMap("flightNumber")]
                [Validation(Required=false)]
                public string FlightNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-05-11</para>
                /// </summary>
                [NameInMap("flyDate")]
                [Validation(Required=false)]
                public string FlyDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("flyFrom")]
                [Validation(Required=false)]
                public string FlyFrom { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>16:00</para>
                /// </summary>
                [NameInMap("flyTime")]
                [Validation(Required=false)]
                public string FlyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("flyTo")]
                [Validation(Required=false)]
                public string FlyTo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>头等舱</para>
                /// </summary>
                [NameInMap("seat")]
                [Validation(Required=false)]
                public string Seat { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("fuelSurcharge")]
            [Validation(Required=false)]
            public string FuelSurcharge { get; set; }

            [NameInMap("fundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            [NameInMap("generalInvoiceDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("taxPreType")]
                [Validation(Required=false)]
                public string TaxPreType { get; set; }

                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("unitPrice")]
                [Validation(Required=false)]
                public string UnitPrice { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>18:00</para>
            /// </summary>
            [NameInMap("getOffTime")]
            [Validation(Required=false)]
            public string GetOffTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17:00</para>
            /// </summary>
            [NameInMap("getOnTime")]
            [Validation(Required=false)]
            public string GetOnTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://XXX.jpg">http://XXX.jpg</a></para>
            /// </summary>
            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            [NameInMap("invoiceStatus")]
            [Validation(Required=false)]
            public string InvoiceStatus { get; set; }

            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ABCD</para>
            /// </summary>
            [NameInMap("issueBy")]
            [Validation(Required=false)]
            public string IssueBy { get; set; }

            [NameInMap("machineCode")]
            [Validation(Required=false)]
            public string MachineCode { get; set; }

            [NameInMap("oilFlag")]
            [Validation(Required=false)]
            public string OilFlag { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("origin")]
            [Validation(Required=false)]
            public string Origin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("passenger")]
            [Validation(Required=false)]
            public string Passenger { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330781****1234</para>
            /// </summary>
            [NameInMap("passengerUserId")]
            [Validation(Required=false)]
            public string PassengerUserId { get; set; }

            [NameInMap("payee")]
            [Validation(Required=false)]
            public string Payee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("printSerialNumber")]
            [Validation(Required=false)]
            public string PrintSerialNumber { get; set; }

            [NameInMap("processInstCode")]
            [Validation(Required=false)]
            public string ProcessInstCode { get; set; }

            [NameInMap("processInstType")]
            [Validation(Required=false)]
            public string ProcessInstType { get; set; }

            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("purchaserBankAccount")]
            [Validation(Required=false)]
            public string PurchaserBankAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:abc@test.com">abc@test.com</a></para>
            /// </summary>
            [NameInMap("receiverEmail")]
            [Validation(Required=false)]
            public string ReceiverEmail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567809</para>
            /// </summary>
            [NameInMap("receiverTel")]
            [Validation(Required=false)]
            public string ReceiverTel { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-09-01</para>
            /// </summary>
            [NameInMap("seatClass")]
            [Validation(Required=false)]
            public string SeatClass { get; set; }

            [NameInMap("secondHandCarInvoiceDetailList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList> SecondHandCarInvoiceDetailList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList : TeaModel {
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

            }

            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("sellerBankAccount")]
            [Validation(Required=false)]
            public string SellerBankAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("serialNo")]
            [Validation(Required=false)]
            public string SerialNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("supplySign")]
            [Validation(Required=false)]
            public string SupplySign { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("surcharge")]
            [Validation(Required=false)]
            public string Surcharge { get; set; }

            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>G1234</para>
            /// </summary>
            [NameInMap("trainNo")]
            [Validation(Required=false)]
            public string TrainNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-09-01</para>
            /// </summary>
            [NameInMap("travelDate")]
            [Validation(Required=false)]
            public string TravelDate { get; set; }

            [NameInMap("usedVehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList : TeaModel {
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

            }

            [NameInMap("vehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
            public class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>code</para>
        /// </summary>
        [NameInMap("invoiceCode")]
        [Validation(Required=false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>155</para>
        /// </summary>
        [NameInMap("invoiceNo")]
        [Validation(Required=false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("receiptCode")]
        [Validation(Required=false)]
        public string ReceiptCode { get; set; }

    }

}
