// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class QueryCityCarApplyResponseBody : TeaModel {
        [NameInMap("applyList")]
        [Validation(Required=false)]
        public List<QueryCityCarApplyResponseBodyApplyList> ApplyList { get; set; }
        public class QueryCityCarApplyResponseBodyApplyList : TeaModel {
            [NameInMap("approverList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListApproverList> ApproverList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListApproverList : TeaModel {
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("operateTime")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public long? Order { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("statusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("userName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("departId")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("departName")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("itineraryList")]
            [Validation(Required=false)]
            public List<QueryCityCarApplyResponseBodyApplyListItineraryList> ItineraryList { get; set; }
            public class QueryCityCarApplyResponseBodyApplyListItineraryList : TeaModel {
                [NameInMap("arrCity")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arrCityCode")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arrDate")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("costCenterId")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("costCenterName")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("depCity")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("depCityCode")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("depDate")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoiceId")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                [NameInMap("invoiceName")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("itineraryId")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("projectCode")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("projectTitle")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("trafficType")]
                [Validation(Required=false)]
                public long? TrafficType { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("statusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("thirdPartApplyId")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            [NameInMap("tripCause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            [NameInMap("tripTitle")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
