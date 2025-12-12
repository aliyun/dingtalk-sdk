// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class QueryTripHotelOrderByPageResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryTripHotelOrderByPageResponseBodyList> List { get; set; }
        public class QueryTripHotelOrderByPageResponseBodyList : TeaModel {
            [NameInMap("checkInTime")]
            [Validation(Required=false)]
            public string CheckInTime { get; set; }

            [NameInMap("checkOutTime")]
            [Validation(Required=false)]
            public string CheckOutTime { get; set; }

            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("consumerInfos")]
            [Validation(Required=false)]
            public List<QueryTripHotelOrderByPageResponseBodyListConsumerInfos> ConsumerInfos { get; set; }
            public class QueryTripHotelOrderByPageResponseBodyListConsumerInfos : TeaModel {
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

            [NameInMap("gmtOrder")]
            [Validation(Required=false)]
            public long? GmtOrder { get; set; }

            [NameInMap("gmtPay")]
            [Validation(Required=false)]
            public long? GmtPay { get; set; }

            [NameInMap("guest")]
            [Validation(Required=false)]
            public string Guest { get; set; }

            [NameInMap("hotelName")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            [NameInMap("hotelOrderStatus")]
            [Validation(Required=false)]
            public string HotelOrderStatus { get; set; }

            [NameInMap("hotelOrderStatusDesc")]
            [Validation(Required=false)]
            public string HotelOrderStatusDesc { get; set; }

            [NameInMap("invoiceId")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            [NameInMap("invoiceTitle")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("night")]
            [Validation(Required=false)]
            public int? Night { get; set; }

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

            [NameInMap("roomNum")]
            [Validation(Required=false)]
            public int? RoomNum { get; set; }

            [NameInMap("roomType")]
            [Validation(Required=false)]
            public string RoomType { get; set; }

            [NameInMap("totalAmount")]
            [Validation(Required=false)]
            public long? TotalAmount { get; set; }

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
