// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class QueryTripTrainOrderByPageResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryTripTrainOrderByPageResponseBodyList> List { get; set; }
        public class QueryTripTrainOrderByPageResponseBodyList : TeaModel {
            [NameInMap("arrivalCity")]
            [Validation(Required=false)]
            public string ArrivalCity { get; set; }

            [NameInMap("arrivalStation")]
            [Validation(Required=false)]
            public string ArrivalStation { get; set; }

            [NameInMap("arrivalTime")]
            [Validation(Required=false)]
            public string ArrivalTime { get; set; }

            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<QueryTripTrainOrderByPageResponseBodyListConsumerInfos> ConsumerInfos { get; set; }
            public class QueryTripTrainOrderByPageResponseBodyListConsumerInfos : TeaModel {
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

            [NameInMap("departmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("departmentName")]
            [Validation(Required=false)]
            public string DepartmentName { get; set; }

            [NameInMap("departureCity")]
            [Validation(Required=false)]
            public string DepartureCity { get; set; }

            [NameInMap("departureStation")]
            [Validation(Required=false)]
            public string DepartureStation { get; set; }

            [NameInMap("departureTime")]
            [Validation(Required=false)]
            public string DepartureTime { get; set; }

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

            [NameInMap("payType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("runTime")]
            [Validation(Required=false)]
            public string RunTime { get; set; }

            [NameInMap("seatType")]
            [Validation(Required=false)]
            public string SeatType { get; set; }

            [NameInMap("ticketCount")]
            [Validation(Required=false)]
            public string TicketCount { get; set; }

            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

            [NameInMap("trainNumber")]
            [Validation(Required=false)]
            public string TrainNumber { get; set; }

            [NameInMap("trainOrderStatus")]
            [Validation(Required=false)]
            public string TrainOrderStatus { get; set; }

            [NameInMap("trainOrderStatusDesc")]
            [Validation(Required=false)]
            public string TrainOrderStatusDesc { get; set; }

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
