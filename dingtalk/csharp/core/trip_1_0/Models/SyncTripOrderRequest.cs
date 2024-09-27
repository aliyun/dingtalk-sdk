// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripOrderRequest : TeaModel {
        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("bizExtension")]
        [Validation(Required=false)]
        public string BizExtension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BUSSINESS</para>
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CNY</para>
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("discountAmount")]
        [Validation(Required=false)]
        public string DiscountAmount { get; set; }

        [NameInMap("endorseFlag")]
        [Validation(Required=false)]
        public bool? EndorseFlag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public SyncTripOrderRequestEvent Event { get; set; }
        public class SyncTripOrderRequestEvent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INIT</para>
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-15 10:10:10</para>
            /// </summary>
            [NameInMap("gmtAction")]
            [Validation(Required=false)]
            public string GmtAction { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-15 10:10:10</para>
        /// </summary>
        [NameInMap("gmtOrder")]
        [Validation(Required=false)]
        public string GmtOrder { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-15 10:10:10</para>
        /// </summary>
        [NameInMap("gmtPay")]
        [Validation(Required=false)]
        public string GmtPay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-15 10:10:10</para>
        /// </summary>
        [NameInMap("gmtRefund")]
        [Validation(Required=false)]
        public string GmtRefund { get; set; }

        [NameInMap("invoiceApplyUrl")]
        [Validation(Required=false)]
        public string InvoiceApplyUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20220510170058192311</para>
        /// </summary>
        [NameInMap("journeyBizNo")]
        [Validation(Required=false)]
        public string JourneyBizNo { get; set; }

        [NameInMap("orderDetails")]
        [Validation(Required=false)]
        public List<SyncTripOrderRequestOrderDetails> OrderDetails { get; set; }
        public class SyncTripOrderRequestOrderDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-20 12:20:00</para>
            /// </summary>
            [NameInMap("arrivalTime")]
            [Validation(Required=false)]
            public string ArrivalTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>红色</para>
            /// </summary>
            [NameInMap("carColor")]
            [Validation(Required=false)]
            public string CarColor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>帕萨特</para>
            /// </summary>
            [NameInMap("carModel")]
            [Validation(Required=false)]
            public string CarModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙A0Z***7</para>
            /// </summary>
            [NameInMap("carNumber")]
            [Validation(Required=false)]
            public string CarNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>单早</para>
            /// </summary>
            [NameInMap("cateringType")]
            [Validation(Required=false)]
            public string CateringType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-20 14:00:00</para>
            /// </summary>
            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public string CheckInTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-21 12:00:00</para>
            /// </summary>
            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public string CheckOutTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-20 10:00:00</para>
            /// </summary>
            [NameInMap("departTime")]
            [Validation(Required=false)]
            public string DepartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("destinationCity")]
            [Validation(Required=false)]
            public string DestinationCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>151</para>
            /// </summary>
            [NameInMap("destinationCityCode")]
            [Validation(Required=false)]
            public string DestinationCityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("destinationStation")]
            [Validation(Required=false)]
            public string DestinationStation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>T3</para>
            /// </summary>
            [NameInMap("destinationTerminalBuilding")]
            [Validation(Required=false)]
            public string DestinationTerminalBuilding { get; set; }

            [NameInMap("detailAmount")]
            [Validation(Required=false)]
            public string DetailAmount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>浙江省杭州市余杭区聚橙路文昌路</para>
            /// </summary>
            [NameInMap("hotelAddress")]
            [Validation(Required=false)]
            public string HotelAddress { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("hotelCity")]
            [Validation(Required=false)]
            public string HotelCity { get; set; }

            [NameInMap("hotelLocation")]
            [Validation(Required=false)]
            public SyncTripOrderRequestOrderDetailsHotelLocation HotelLocation { get; set; }
            public class SyncTripOrderRequestOrderDetailsHotelLocation : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30.278569</para>
                /// </summary>
                [NameInMap("lat")]
                [Validation(Required=false)]
                public string Lat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>120.023458</para>
                /// </summary>
                [NameInMap("lon")]
                [Validation(Required=false)]
                public string Lon { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>GCJ02</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://ditu.amap.com/place/B0FFIYYAIA">https://ditu.amap.com/place/B0FFIYYAIA</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>亲橙客栈</para>
            /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("originCity")]
            [Validation(Required=false)]
            public string OriginCity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>150</para>
            /// </summary>
            [NameInMap("originCityCode")]
            [Validation(Required=false)]
            public string OriginCityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("originStation")]
            [Validation(Required=false)]
            public string OriginStation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>T3</para>
            /// </summary>
            [NameInMap("originTerminalBuilding")]
            [Validation(Required=false)]
            public string OriginTerminalBuilding { get; set; }

            [NameInMap("roomCount")]
            [Validation(Required=false)]
            public int? RoomCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>经济舱/7车12A</para>
            /// </summary>
            [NameInMap("seatInfo")]
            [Validation(Required=false)]
            public string SeatInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>REALTIME</para>
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://dingtalk.com/static/logo.png">http://dingtalk.com/static/logo.png</a></para>
            /// </summary>
            [NameInMap("subSupplyLogo")]
            [Validation(Required=false)]
            public string SubSupplyLogo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>国航</para>
            /// </summary>
            [NameInMap("subSupplyName")]
            [Validation(Required=false)]
            public string SubSupplyName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>专车</para>
            /// </summary>
            [NameInMap("taxiType")]
            [Validation(Required=false)]
            public string TaxiType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-20 14:00:00</para>
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CA1762</para>
            /// </summary>
            [NameInMap("transportNumber")]
            [Validation(Required=false)]
            public string TransportNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>商务标准间</para>
            /// </summary>
            [NameInMap("typeDescription")]
            [Validation(Required=false)]
            public string TypeDescription { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https:dingtalk.com/tripOrder/20220510170058192311</para>
        /// </summary>
        [NameInMap("orderUrl")]
        [Validation(Required=false)]
        public string OrderUrl { get; set; }

        [NameInMap("processId")]
        [Validation(Required=false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("realAmount")]
        [Validation(Required=false)]
        public string RealAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding32fff839a3e0105d</para>
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tmcCorpId")]
        [Validation(Required=false)]
        public string TmcCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FLIGHT</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
