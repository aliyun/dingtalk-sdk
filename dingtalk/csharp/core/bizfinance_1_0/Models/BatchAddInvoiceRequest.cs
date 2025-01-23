// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class BatchAddInvoiceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("generalInvoiceVOList")]
        [Validation(Required=false)]
        public List<BatchAddInvoiceRequestGeneralInvoiceVOList> GeneralInvoiceVOList { get; set; }
        public class BatchAddInvoiceRequestGeneralInvoiceVOList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("accountPeriod")]
            [Validation(Required=false)]
            public string AccountPeriod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("amountWithTax")]
            [Validation(Required=false)]
            public string AmountWithTax { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("checkCode")]
            [Validation(Required=false)]
            public string CheckCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2010-12-12</para>
            /// </summary>
            [NameInMap("checkTime")]
            [Validation(Required=false)]
            public string CheckTime { get; set; }

            [NameInMap("domesticOrIntl")]
            [Validation(Required=false)]
            public string DomesticOrIntl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("drawerName")]
            [Validation(Required=false)]
            public string DrawerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-12-10</para>
            /// </summary>
            [NameInMap("drewDate")]
            [Validation(Required=false)]
            public string DrewDate { get; set; }

            [NameInMap("eFlightItineraryDetailVOList")]
            [Validation(Required=false)]
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList> EFlightItineraryDetailVOList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListEFlightItineraryDetailVOList : TeaModel {
                [NameInMap("carrier")]
                [Validation(Required=false)]
                public string Carrier { get; set; }

                [NameInMap("className")]
                [Validation(Required=false)]
                public string ClassName { get; set; }

                [NameInMap("flightNumber")]
                [Validation(Required=false)]
                public string FlightNumber { get; set; }

                [NameInMap("flyDate")]
                [Validation(Required=false)]
                public string FlyDate { get; set; }

                [NameInMap("flyFrom")]
                [Validation(Required=false)]
                public string FlyFrom { get; set; }

                [NameInMap("flyTime")]
                [Validation(Required=false)]
                public string FlyTime { get; set; }

                [NameInMap("flyTo")]
                [Validation(Required=false)]
                public string FlyTo { get; set; }

                [NameInMap("invoiceDetailNumber")]
                [Validation(Required=false)]
                public string InvoiceDetailNumber { get; set; }

                [NameInMap("invoiceId")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("seat")]
                [Validation(Required=false)]
                public string Seat { get; set; }

            }

            [NameInMap("eTicketNo")]
            [Validation(Required=false)]
            public string ETicketNo { get; set; }

            [NameInMap("eTrainTicketDetailVOList")]
            [Validation(Required=false)]
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList> ETrainTicketDetailVOList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListETrainTicketDetailVOList : TeaModel {
                [NameInMap("airConditionType")]
                [Validation(Required=false)]
                public string AirConditionType { get; set; }

                [NameInMap("carriageNo")]
                [Validation(Required=false)]
                public string CarriageNo { get; set; }

                [NameInMap("destination")]
                [Validation(Required=false)]
                public string Destination { get; set; }

                [NameInMap("eticketNo")]
                [Validation(Required=false)]
                public string EticketNo { get; set; }

                [NameInMap("getOnTime")]
                [Validation(Required=false)]
                public string GetOnTime { get; set; }

                [NameInMap("invoiceId")]
                [Validation(Required=false)]
                public string InvoiceId { get; set; }

                [NameInMap("origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

                [NameInMap("passengerUserId")]
                [Validation(Required=false)]
                public string PassengerUserId { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("seatClass")]
                [Validation(Required=false)]
                public string SeatClass { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("taxRate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                [NameInMap("ticketType")]
                [Validation(Required=false)]
                public string TicketType { get; set; }

                [NameInMap("trainNo")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("electronicUrl")]
            [Validation(Required=false)]
            public string ElectronicUrl { get; set; }

            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INPUT_VAT</para>
            /// </summary>
            [NameInMap("financeType")]
            [Validation(Required=false)]
            public string FinanceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RED</para>
            /// </summary>
            [NameInMap("fundType")]
            [Validation(Required=false)]
            public string FundType { get; set; }

            [NameInMap("generalInvoiceDetailVOList")]
            [Validation(Required=false)]
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList : TeaModel {
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

            [NameInMap("gpNo")]
            [Validation(Required=false)]
            public string GpNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://XXX.jpg">http://XXX.jpg</a></para>
            /// </summary>
            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("invoiceCode")]
            [Validation(Required=false)]
            public string InvoiceCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("invoiceNo")]
            [Validation(Required=false)]
            public string InvoiceNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("invoiceStatus")]
            [Validation(Required=false)]
            public string InvoiceStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>INTPUT_VAT</para>
            /// </summary>
            [NameInMap("invoiceType")]
            [Validation(Required=false)]
            public string InvoiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("machineCode")]
            [Validation(Required=false)]
            public string MachineCode { get; set; }

            [NameInMap("ofdUrl")]
            [Validation(Required=false)]
            public string OfdUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("oilFlag")]
            [Validation(Required=false)]
            public string OilFlag { get; set; }

            [NameInMap("passenger")]
            [Validation(Required=false)]
            public string Passenger { get; set; }

            [NameInMap("passengerUserId")]
            [Validation(Required=false)]
            public string PassengerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("payee")]
            [Validation(Required=false)]
            public string Payee { get; set; }

            [NameInMap("pdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("processInstCode")]
            [Validation(Required=false)]
            public string ProcessInstCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("processInstType")]
            [Validation(Required=false)]
            public string ProcessInstType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州市</para>
            /// </summary>
            [NameInMap("purchaserAddress")]
            [Validation(Required=false)]
            public string PurchaserAddress { get; set; }

            [NameInMap("purchaserBankAccount")]
            [Validation(Required=false)]
            public string PurchaserBankAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>建行</para>
            /// </summary>
            [NameInMap("purchaserBankNameAccount")]
            [Validation(Required=false)]
            public string PurchaserBankNameAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("purchaserName")]
            [Validation(Required=false)]
            public string PurchaserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>155655</para>
            /// </summary>
            [NameInMap("purchaserTaxNo")]
            [Validation(Required=false)]
            public string PurchaserTaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1333333333</para>
            /// </summary>
            [NameInMap("purchaserTel")]
            [Validation(Required=false)]
            public string PurchaserTel { get; set; }

            [NameInMap("receiverEmail")]
            [Validation(Required=false)]
            public string ReceiverEmail { get; set; }

            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            [NameInMap("receiverTel")]
            [Validation(Required=false)]
            public string ReceiverTel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("reviewer")]
            [Validation(Required=false)]
            public string Reviewer { get; set; }

            [NameInMap("secondHandCarInvoiceDetailList")]
            [Validation(Required=false)]
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList> SecondHandCarInvoiceDetailList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>8852</para>
            /// </summary>
            [NameInMap("sellerAddress")]
            [Validation(Required=false)]
            public string SellerAddress { get; set; }

            [NameInMap("sellerBankAccount")]
            [Validation(Required=false)]
            public string SellerBankAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>招商银行</para>
            /// </summary>
            [NameInMap("sellerBankNameAccount")]
            [Validation(Required=false)]
            public string SellerBankNameAccount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("sellerName")]
            [Validation(Required=false)]
            public string SellerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2202</para>
            /// </summary>
            [NameInMap("sellerTaxNo")]
            [Validation(Required=false)]
            public string SellerTaxNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13355222222</para>
            /// </summary>
            [NameInMap("sellerTel")]
            [Validation(Required=false)]
            public string SellerTel { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("supplySign")]
            [Validation(Required=false)]
            public string SupplySign { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("taxAmount")]
            [Validation(Required=false)]
            public string TaxAmount { get; set; }

            [NameInMap("usedVehicleSaleDetailVOList")]
            [Validation(Required=false)]
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList : TeaModel {
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
            public List<BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
            public class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList : TeaModel {
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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("verifyStatus")]
            [Validation(Required=false)]
            public string VerifyStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("voucherCode")]
            [Validation(Required=false)]
            public string VoucherCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("voucherStatus")]
            [Validation(Required=false)]
            public string VoucherStatus { get; set; }

            [NameInMap("xmlUrl")]
            [Validation(Required=false)]
            public string XmlUrl { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>APPROVAL</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
