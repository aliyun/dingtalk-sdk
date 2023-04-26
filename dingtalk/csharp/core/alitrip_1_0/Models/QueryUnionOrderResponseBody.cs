// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryUnionOrderResponseBody : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("flightList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyFlightList> FlightList { get; set; }
        public class QueryUnionOrderResponseBodyFlightList : TeaModel {
            [NameInMap("flightOrderId")]
            [Validation(Required=false)]
            public long? FlightOrderId { get; set; }

            [NameInMap("flightOrderStatus")]
            [Validation(Required=false)]
            public long? FlightOrderStatus { get; set; }

        }

        [NameInMap("hotelList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyHotelList> HotelList { get; set; }
        public class QueryUnionOrderResponseBodyHotelList : TeaModel {
            [NameInMap("hotelOrderId")]
            [Validation(Required=false)]
            public long? HotelOrderId { get; set; }

            [NameInMap("hotelOrderStatus")]
            [Validation(Required=false)]
            public long? HotelOrderStatus { get; set; }

        }

        [NameInMap("trainList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyTrainList> TrainList { get; set; }
        public class QueryUnionOrderResponseBodyTrainList : TeaModel {
            [NameInMap("trainOrderId")]
            [Validation(Required=false)]
            public long? TrainOrderId { get; set; }

            [NameInMap("trainOrderstatus")]
            [Validation(Required=false)]
            public long? TrainOrderstatus { get; set; }

        }

        [NameInMap("vehicleList")]
        [Validation(Required=false)]
        public List<QueryUnionOrderResponseBodyVehicleList> VehicleList { get; set; }
        public class QueryUnionOrderResponseBodyVehicleList : TeaModel {
            [NameInMap("vehicleOrderId")]
            [Validation(Required=false)]
            public long? VehicleOrderId { get; set; }

            [NameInMap("vehicleOrderStatus")]
            [Validation(Required=false)]
            public long? VehicleOrderStatus { get; set; }

        }

    }

}
