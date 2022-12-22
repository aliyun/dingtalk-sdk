// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncTripOrderRequest : TeaModel {
        /// <summary>
        /// 订单渠道，枚举值：BUSINESS、CUSTOMER
        /// </summary>
        [NameInMap("channelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [NameInMap("currency")]
        [Validation(Required=false)]
        public string Currency { get; set; }

        /// <summary>
        /// 钉钉用户id
        /// </summary>
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [NameInMap("discountAmount")]
        [Validation(Required=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 是否是改签单
        /// </summary>
        [NameInMap("endorseFlag")]
        [Validation(Required=false)]
        public bool? EndorseFlag { get; set; }

        [NameInMap("event")]
        [Validation(Required=false)]
        public SyncTripOrderRequestEvent Event { get; set; }
        public class SyncTripOrderRequestEvent : TeaModel {
            /// <summary>
            /// 订单事件
            /// </summary>
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// 事件时间
            /// </summary>
            [NameInMap("gmtAction")]
            [Validation(Required=false)]
            public string GmtAction { get; set; }

        }

        /// <summary>
        /// 下单时间
        /// </summary>
        [NameInMap("gmtOrder")]
        [Validation(Required=false)]
        public string GmtOrder { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [NameInMap("gmtPay")]
        [Validation(Required=false)]
        public string GmtPay { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [NameInMap("gmtRefund")]
        [Validation(Required=false)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 发票申请链接
        /// </summary>
        [NameInMap("invoiceApplyUrl")]
        [Validation(Required=false)]
        public string InvoiceApplyUrl { get; set; }

        /// <summary>
        /// 行程单号
        /// </summary>
        [NameInMap("journeyBizNo")]
        [Validation(Required=false)]
        public string JourneyBizNo { get; set; }

        /// <summary>
        /// 订单详情列表
        /// </summary>
        [NameInMap("orderDetails")]
        [Validation(Required=false)]
        public List<SyncTripOrderRequestOrderDetails> OrderDetails { get; set; }
        public class SyncTripOrderRequestOrderDetails : TeaModel {
            /// <summary>
            /// 到达时间
            /// </summary>
            [NameInMap("arrivalTime")]
            [Validation(Required=false)]
            public string ArrivalTime { get; set; }

            /// <summary>
            /// 车辆颜色
            /// </summary>
            [NameInMap("carColor")]
            [Validation(Required=false)]
            public string CarColor { get; set; }

            /// <summary>
            /// 车辆型号
            /// </summary>
            [NameInMap("carModel")]
            [Validation(Required=false)]
            public string CarModel { get; set; }

            /// <summary>
            /// 车牌号
            /// </summary>
            [NameInMap("carNumber")]
            [Validation(Required=false)]
            public string CarNumber { get; set; }

            /// <summary>
            /// 餐食描述
            /// </summary>
            [NameInMap("cateringType")]
            [Validation(Required=false)]
            public string CateringType { get; set; }

            /// <summary>
            /// 入住时间
            /// </summary>
            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public string CheckInTime { get; set; }

            /// <summary>
            /// 离店时间
            /// </summary>
            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public string CheckOutTime { get; set; }

            /// <summary>
            /// 出发时间
            /// </summary>
            [NameInMap("departTime")]
            [Validation(Required=false)]
            public string DepartTime { get; set; }

            /// <summary>
            /// 目的地城市
            /// </summary>
            [NameInMap("destinationCity")]
            [Validation(Required=false)]
            public string DestinationCity { get; set; }

            /// <summary>
            /// 目的地城市码
            /// </summary>
            [NameInMap("destinationCityCode")]
            [Validation(Required=false)]
            public string DestinationCityCode { get; set; }

            /// <summary>
            /// 目的站名称
            /// </summary>
            [NameInMap("destinationStation")]
            [Validation(Required=false)]
            public string DestinationStation { get; set; }

            /// <summary>
            /// 酒店地址
            /// </summary>
            [NameInMap("hotelAddress")]
            [Validation(Required=false)]
            public string HotelAddress { get; set; }

            [NameInMap("hotelCity")]
            [Validation(Required=false)]
            public string HotelCity { get; set; }

            /// <summary>
            /// 酒店定位信息
            /// </summary>
            [NameInMap("hotelLocation")]
            [Validation(Required=false)]
            public SyncTripOrderRequestOrderDetailsHotelLocation HotelLocation { get; set; }
            public class SyncTripOrderRequestOrderDetailsHotelLocation : TeaModel {
                /// <summary>
                /// 纬度
                /// </summary>
                [NameInMap("lat")]
                [Validation(Required=false)]
                public string Lat { get; set; }

                /// <summary>
                /// 经度
                /// </summary>
                [NameInMap("lon")]
                [Validation(Required=false)]
                public string Lon { get; set; }

                /// <summary>
                /// 坐标数据源
                /// - BD09：来自百度地图的经纬坐标
                /// - GCJ02: 来自高德地图，腾讯地图，Apple地图的坐标
                /// - WGS84: 来自GPS的坐标
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// 定位url
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 酒店名称
            /// </summary>
            [NameInMap("hotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            /// <summary>
            /// 出发地城市
            /// </summary>
            [NameInMap("originCity")]
            [Validation(Required=false)]
            public string OriginCity { get; set; }

            /// <summary>
            /// 出发地城市码
            /// </summary>
            [NameInMap("originCityCode")]
            [Validation(Required=false)]
            public string OriginCityCode { get; set; }

            /// <summary>
            /// 出发站名称
            /// </summary>
            [NameInMap("originStation")]
            [Validation(Required=false)]
            public string OriginStation { get; set; }

            /// <summary>
            /// 房间数
            /// </summary>
            [NameInMap("roomCount")]
            [Validation(Required=false)]
            public int? RoomCount { get; set; }

            /// <summary>
            /// 舱位
            /// </summary>
            [NameInMap("seatInfo")]
            [Validation(Required=false)]
            public string SeatInfo { get; set; }

            /// <summary>
            /// “服务类型”
            /// </summary>
            [NameInMap("serviceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            /// <summary>
            /// 下游供应商logo
            /// </summary>
            [NameInMap("subSupplyLogo")]
            [Validation(Required=false)]
            public string SubSupplyLogo { get; set; }

            /// <summary>
            /// 下游供应商名称
            /// </summary>
            [NameInMap("subSupplyName")]
            [Validation(Required=false)]
            public string SubSupplyName { get; set; }

            /// <summary>
            /// 专车类型
            /// </summary>
            [NameInMap("taxiType")]
            [Validation(Required=false)]
            public string TaxiType { get; set; }

            /// <summary>
            /// 联系方式
            /// </summary>
            [NameInMap("telephone")]
            [Validation(Required=false)]
            public string Telephone { get; set; }

            /// <summary>
            /// 火车/航班班次
            /// </summary>
            [NameInMap("transportNumber")]
            [Validation(Required=false)]
            public string TransportNumber { get; set; }

            /// <summary>
            /// 房型描述
            /// </summary>
            [NameInMap("typeDescription")]
            [Validation(Required=false)]
            public string TypeDescription { get; set; }

        }

        /// <summary>
        /// 供应商订单号
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单详情链接
        /// </summary>
        [NameInMap("orderUrl")]
        [Validation(Required=false)]
        public string OrderUrl { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [NameInMap("realAmount")]
        [Validation(Required=false)]
        public string RealAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [NameInMap("refundAmount")]
        [Validation(Required=false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 供应商关联订单号
        /// </summary>
        [NameInMap("relativeOrderNo")]
        [Validation(Required=false)]
        public string RelativeOrderNo { get; set; }

        /// <summary>
        /// 来源埋点
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 用户组织id
        /// </summary>
        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
