// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryUnionOrderResponseBody : TeaModel {
        /// <summary>
        /// 飞机订单信息
        /// </summary>
        [NameInMap("flightList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyFlightList> FlightList { get; set; }
        public class QueryUnionOrderResponseBodyFlightList : TeaModel {
            /// <summary>
            /// 订单id
            /// </summary>
            [NameInMap("flightOrderId")]
            [Validation(Required=false)]
            public long? FlightOrderId { get; set; }

            /// <summary>
            /// 订单状态：0待支付,1出票中,2已关闭,3有改签单,4有退票单,5出票成功,6退票申请中,7改签申请中
            /// </summary>
            [NameInMap("flightOrderStatus")]
            [Validation(Required=false)]
            public long? FlightOrderStatus { get; set; }

        }

        /// <summary>
        /// 企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 火车订单信息
        /// </summary>
        [NameInMap("trainList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyTrainList> TrainList { get; set; }
        public class QueryUnionOrderResponseBodyTrainList : TeaModel {
            /// <summary>
            /// 火车订单号
            /// </summary>
            [NameInMap("trainOrderId")]
            [Validation(Required=false)]
            public long? TrainOrderId { get; set; }

            /// <summary>
            /// 订单状态：0待支付,1出票中,2已关闭,3,改签成功,4退票成功,5出票完成,6退票申请中,7改签申请中,8已出票,已发货,9出票失败,10改签失败,11退票失败
            /// </summary>
            [NameInMap("trainOrderstatus")]
            [Validation(Required=false)]
            public long? TrainOrderstatus { get; set; }

        }

        /// <summary>
        /// 酒店订单信息
        /// </summary>
        [NameInMap("hotelList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyHotelList> HotelList { get; set; }
        public class QueryUnionOrderResponseBodyHotelList : TeaModel {
            /// <summary>
            /// 酒店订单号
            /// </summary>
            [NameInMap("hotelOrderId")]
            [Validation(Required=false)]
            public long? HotelOrderId { get; set; }

            /// <summary>
            /// 订单状态1:等待确认,2:等待付款,3:预订成功,4:申请退款,5:退款成功,6:已关闭,7:结账成功,8:支付成功
            /// </summary>
            [NameInMap("hotelOrderStatus")]
            [Validation(Required=false)]
            public long? HotelOrderStatus { get; set; }

        }

        /// <summary>
        /// 用车订单信息
        /// </summary>
        [NameInMap("vehicleList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyVehicleList> VehicleList { get; set; }
        public class QueryUnionOrderResponseBodyVehicleList : TeaModel {
            /// <summary>
            /// 用车订单号
            /// </summary>
            [NameInMap("vehicleOrderId")]
            [Validation(Required=false)]
            public long? VehicleOrderId { get; set; }

            /// <summary>
            /// 订单状态:0:初始状态,1:已超时,2:派单成功,3:派单失败,4:已退款,5:已支付,6:已取消
            /// </summary>
            [NameInMap("vehicleOrderStatus")]
            [Validation(Required=false)]
            public long? VehicleOrderStatus { get; set; }

        }

    }

}
