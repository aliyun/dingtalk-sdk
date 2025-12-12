// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class QueryTripFlightOrderByPageResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryTripFlightOrderByPageResponseBodyList> List { get; set; }
        public class QueryTripFlightOrderByPageResponseBodyList : TeaModel {
            [NameInMap("arrivalTime")]
            [Validation(Required=false)]
            public string ArrivalTime { get; set; }

            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<QueryTripFlightOrderByPageResponseBodyListConsumerInfos> ConsumerInfos { get; set; }
            public class QueryTripFlightOrderByPageResponseBodyListConsumerInfos : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("staffFlag")]
                [Validation(Required=false)]
                public bool? StaffFlag { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("contactName")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("costCenter")]
            [Validation(Required=false)]
            public string CostCenter { get; set; }

            [NameInMap("costCenterCode")]
            [Validation(Required=false)]
            public string CostCenterCode { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("departTime")]
            [Validation(Required=false)]
            public string DepartTime { get; set; }

            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("destinationCity")]
            [Validation(Required=false)]
            public string DestinationCity { get; set; }

            [NameInMap("destinationStation")]
            [Validation(Required=false)]
            public string DestinationStation { get; set; }

            [NameInMap("flightOrderStatus")]
            [Validation(Required=false)]
            public int? FlightOrderStatus { get; set; }

            [NameInMap("flightOrderStatusDesc")]
            [Validation(Required=false)]
            public string FlightOrderStatusDesc { get; set; }

            [NameInMap("gmtOrder")]
            [Validation(Required=false)]
            public long? GmtOrder { get; set; }

            [NameInMap("gmtPay")]
            [Validation(Required=false)]
            public long? GmtPay { get; set; }

            [NameInMap("invoiceId")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            [NameInMap("invoiceTitle")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("orderDetails")]
            [Validation(Required=false)]
            public string OrderDetails { get; set; }

            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("originCity")]
            [Validation(Required=false)]
            public string OriginCity { get; set; }

            [NameInMap("originStation")]
            [Validation(Required=false)]
            public string OriginStation { get; set; }

            [NameInMap("passengerCount")]
            [Validation(Required=false)]
            public int? PassengerCount { get; set; }

            [NameInMap("passengerName")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("seatType")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

            [NameInMap("transportNumber")]
            [Validation(Required=false)]
            public string TransportNumber { get; set; }

            [NameInMap("tripType")]
            [Validation(Required=false)]
            public string TripType { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
