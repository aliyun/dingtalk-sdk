// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryCustomerTaskUserDetailResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryCustomerTaskUserDetailResponseBodyRecords> Records { get; set; }
        public class QueryCustomerTaskUserDetailResponseBodyRecords : TeaModel {
            [NameInMap("customerNames")]
            [Validation(Required=false)]
            public string CustomerNames { get; set; }

            [NameInMap("errorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("errorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            [NameInMap("eventTrackResponses")]
            [Validation(Required=false)]
            public List<QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses> EventTrackResponses { get; set; }
            public class QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses : TeaModel {
                [NameInMap("clickTime")]
                [Validation(Required=false)]
                public string ClickTime { get; set; }

                [NameInMap("eventTrackId")]
                [Validation(Required=false)]
                public string EventTrackId { get; set; }

                [NameInMap("onClick")]
                [Validation(Required=false)]
                public bool? OnClick { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("openBatchTaskId")]
            [Validation(Required=false)]
            public string OpenBatchTaskId { get; set; }

            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public long? ReadStatus { get; set; }

            [NameInMap("readTime")]
            [Validation(Required=false)]
            public string ReadTime { get; set; }

            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            [NameInMap("sendTime")]
            [Validation(Required=false)]
            public string SendTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
