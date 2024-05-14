// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerStatisticsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ReportCustomerStatisticsResponseBodyRecords> Records { get; set; }
        public class ReportCustomerStatisticsResponseBodyRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("customerCnt")]
            [Validation(Required=false)]
            public long? CustomerCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupSetName")]
            [Validation(Required=false)]
            public string GroupSetName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("loginCnt")]
            [Validation(Required=false)]
            public long? LoginCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openConvCnt")]
            [Validation(Required=false)]
            public long? OpenConvCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("senderCnt")]
            [Validation(Required=false)]
            public long? SenderCnt { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
