// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerDetailResponseBody : TeaModel {
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
        public List<ReportCustomerDetailResponseBodyRecords> Records { get; set; }
        public class ReportCustomerDetailResponseBodyRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasLogin")]
            [Validation(Required=false)]
            public bool? HasLogin { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasOpenConv")]
            [Validation(Required=false)]
            public bool? HasOpenConv { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
