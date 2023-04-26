// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerDetailResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ReportCustomerDetailResponseBodyRecords> Records { get; set; }
        public class ReportCustomerDetailResponseBodyRecords : TeaModel {
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("hasLogin")]
            [Validation(Required=false)]
            public bool? HasLogin { get; set; }

            [NameInMap("hasOpenConv")]
            [Validation(Required=false)]
            public bool? HasOpenConv { get; set; }

            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
