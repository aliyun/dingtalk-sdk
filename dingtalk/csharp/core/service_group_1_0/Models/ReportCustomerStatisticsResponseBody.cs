// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerStatisticsResponseBody : TeaModel {
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ReportCustomerStatisticsResponseBodyRecords> Records { get; set; }
        public class ReportCustomerStatisticsResponseBodyRecords : TeaModel {
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("customerCnt")]
            [Validation(Required=false)]
            public long? CustomerCnt { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("groupSetName")]
            [Validation(Required=false)]
            public string GroupSetName { get; set; }

            [NameInMap("loginCnt")]
            [Validation(Required=false)]
            public long? LoginCnt { get; set; }

            [NameInMap("openConvCnt")]
            [Validation(Required=false)]
            public long? OpenConvCnt { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            [NameInMap("senderCnt")]
            [Validation(Required=false)]
            public long? SenderCnt { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
