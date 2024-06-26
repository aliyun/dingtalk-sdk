// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripOrderRequest : TeaModel {
        [NameInMap("bizExtension")]
        [Validation(Required=false)]
        public string BizExtension { get; set; }

        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        [NameInMap("discountAmount")]
        [Validation(Required=false)]
        public string DiscountAmount { get; set; }

        [NameInMap("endorseFlag")]
        [Validation(Required=false)]
        public bool? EndorseFlag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public SyncTripOrderRequestEvent Event { get; set; }
        public class SyncTripOrderRequestEvent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("gmtAction")]
            [Validation(Required=false)]
            public string GmtAction { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("gmtOrder")]
        [Validation(Required=false)]
        public string GmtOrder { get; set; }

        [NameInMap("gmtPay")]
        [Validation(Required=false)]
        public string GmtPay { get; set; }

        [NameInMap("gmtRefund")]
        [Validation(Required=false)]
        public string GmtRefund { get; set; }

        [NameInMap("invoiceApplyUrl")]
        [Validation(Required=false)]
        public string InvoiceApplyUrl { get; set; }

        [NameInMap("journeyBizNo")]
        [Validation(Required=false)]
        public string JourneyBizNo { get; set; }

        [NameInMap("orderDetails")]
        [Validation(Required=false)]
        public List<SyncTripOrderRequestOrderDetails> OrderDetails { get; set; }
        public class SyncTripOrderRequestOrderDetails : TeaModel {
            [NameInMap("arrivalTime")]
            [Validation(Required=false)]
            public string ArrivalTime { get; set; }

            [NameInMap("carColor")]
            [Validation(Required=false)]
            public string CarColor { get; set; }

            [NameInMap("carModel")]
            [Validation(Required=false)]
            public string CarModel { get; set; }

            [NameInMap("carNumber")]
            [Validation(Required=false)]
            public string CarNumber { get; set; }

            [NameInMap("cateringType")]
            [Validation(Required=false)]
            public string CateringType { get; set; }

            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public string CheckInTime { get; set; }

            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public string CheckOutTime { get; set; }

            [NameInMap("departTime")]
            [Validation(Required=false)]
            public string DepartTime { get; set; }

            [NameInMap("destinationCity")]
            [Validation(Required=false)]
            public string DestinationCity { get; set; }

            [NameInMap("destinationCityCode")]
            [Validation(Required=false)]
            public string DestinationCityCode { get; set; }

            [NameInMap("destinationStation")]
            [Validation(Required=false)]
            public string DestinationStation { get; set; }

            [NameInMap("destinationTerminalBuilding")]
            [Validation(Required=false)]
            public string DestinationTerminalBuilding { get; set; }

            [NameInMap("detailAmount")]
            [Validation(Required=false)]
            public string DetailAmount { get; set; }

            [NameInMap("hotelAddress")]
            [Validation(Required=false)]
            public string HotelAddress { get; set; }

            [NameInMap("hotelCity")]
            [Validation(Required=false)]
            public string HotelCity { get; set; }

            [NameInMap("hotelLocation")]
            [Validation(Required=false)]
            public SyncTripOrderRequestOrderDetailsHotelLocation HotelLocation { get; set; }
            public class SyncTripOrderRequestOrderDetailsHotelLocation : TeaModel {
                [NameInMap("lat")]
                [Validation(Required=false)]
                public string Lat { get; set; }

                [NameInMap("lon")]
                [Validation(Required=false)]
                public string Lon { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("hotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            [NameInMap("openConsumerInfo")]
            [Validation(Required=false)]
            public List<SyncTripOrderRequestOrderDetailsOpenConsumerInfo> OpenConsumerInfo { get; set; }
            public class SyncTripOrderRequestOrderDetailsOpenConsumerInfo : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("staffFlag")]
                [Validation(Required=false)]
                public bool? StaffFlag { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("ticketAmount")]
                [Validation(Required=false)]
                public string TicketAmount { get; set; }

                [NameInMap("ticketNo")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("originCity")]
            [Validation(Required=false)]
            public string OriginCity { get; set; }

            [NameInMap("originCityCode")]
            [Validation(Required=false)]
            public string OriginCityCode { get; set; }

            [NameInMap("originStation")]
            [Validation(Required=false)]
            public string OriginStation { get; set; }

            [NameInMap("originTerminalBuilding")]
            [Validation(Required=false)]
            public string OriginTerminalBuilding { get; set; }

            [NameInMap("roomCount")]
            [Validation(Required=false)]
            public int? RoomCount { get; set; }

            [NameInMap("seatInfo")]
            [Validation(Required=false)]
            public string SeatInfo { get; set; }

            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("subSupplyLogo")]
            [Validation(Required=false)]
            public string SubSupplyLogo { get; set; }

            [NameInMap("subSupplyName")]
            [Validation(Required=false)]
            public string SubSupplyName { get; set; }

            [NameInMap("taxiType")]
            [Validation(Required=false)]
            public string TaxiType { get; set; }

            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            [NameInMap("transportNumber")]
            [Validation(Required=false)]
            public string TransportNumber { get; set; }

            [NameInMap("typeDescription")]
            [Validation(Required=false)]
            public string TypeDescription { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderUrl")]
        [Validation(Required=false)]
        public string OrderUrl { get; set; }

        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        [NameInMap("realAmount")]
        [Validation(Required=false)]
        public string RealAmount { get; set; }

        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public string RefundAmount { get; set; }

        [NameInMap("relativeOrderNo")]
        [Validation(Required=false)]
        public string RelativeOrderNo { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("supplyLogo")]
        [Validation(Required=false)]
        public string SupplyLogo { get; set; }

        [NameInMap("supplyName")]
        [Validation(Required=false)]
        public string SupplyName { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tmcCorpId")]
        [Validation(Required=false)]
        public string TmcCorpId { get; set; }

        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
