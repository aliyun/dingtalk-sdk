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
                [NameInMap("accountPeriod")]
                [Validation(Required=false)]
                public string AccountPeriod { get; set; }

                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("amountWithTax")]
                [Validation(Required=false)]
                public string AmountWithTax { get; set; }

                [NameInMap("certificationDate")]
                [Validation(Required=false)]
                public string CertificationDate { get; set; }

                [NameInMap("certificationPeriod")]
                [Validation(Required=false)]
                public string CertificationPeriod { get; set; }

                [NameInMap("checkCode")]
                [Validation(Required=false)]
                public string CheckCode { get; set; }

                [NameInMap("checkTime")]
                [Validation(Required=false)]
                public string CheckTime { get; set; }

                [NameInMap("drewDate")]
                [Validation(Required=false)]
                public string DrewDate { get; set; }

                [NameInMap("eFlightItineraryDetailVOList")]
                [Validation(Required=false)]
                public List<GetInvoiceByPageResponseBodyResultListEFlightItineraryDetailVOList> EFlightItineraryDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListEFlightItineraryDetailVOList : TeaModel {
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

                [NameInMap("eTrainTicketDetailVOList")]
                [Validation(Required=false)]
                public List<GetInvoiceByPageResponseBodyResultListETrainTicketDetailVOList> ETrainTicketDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListETrainTicketDetailVOList : TeaModel {
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

                    [NameInMap("seatNo")]
                    [Validation(Required=false)]
                    public string SeatNo { get; set; }

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
                public List<GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList> GeneralInvoiceDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList : TeaModel {
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

                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("invoiceCode")]
                [Validation(Required=false)]
                public string InvoiceCode { get; set; }

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

                [NameInMap("invoiceType")]
                [Validation(Required=false)]
                public string InvoiceType { get; set; }

                [NameInMap("machineCode")]
                [Validation(Required=false)]
                public string MachineCode { get; set; }

                [NameInMap("ofdUrl")]
                [Validation(Required=false)]
                public string OfdUrl { get; set; }

                [NameInMap("oilFlag")]
                [Validation(Required=false)]
                public string OilFlag { get; set; }

                [NameInMap("payee")]
                [Validation(Required=false)]
                public string Payee { get; set; }

                [NameInMap("pdfUrl")]
                [Validation(Required=false)]
                public string PdfUrl { get; set; }

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

                [NameInMap("transportFeeDetailVOList")]
                [Validation(Required=false)]
                public List<GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList> TransportFeeDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList : TeaModel {
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

                [NameInMap("usedVehicleSaleDetailVOList")]
                [Validation(Required=false)]
                public List<GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList> UsedVehicleSaleDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList : TeaModel {
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
                public List<GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList> VehicleSaleDetailVOList { get; set; }
                public class GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList : TeaModel {
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

                [NameInMap("xmlUrl")]
                [Validation(Required=false)]
                public string XmlUrl { get; set; }

            }

            [NameInMap("nextCursor")]
            [Validation(Required=false)]
            public long? NextCursor { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
