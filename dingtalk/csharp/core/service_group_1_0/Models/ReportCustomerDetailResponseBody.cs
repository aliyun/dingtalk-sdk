// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerDetailResponseBody : TeaModel {
        /// <summary>
        /// 页码
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<ReportCustomerDetailResponseBodyRecords> Records { get; set; }
        public class ReportCustomerDetailResponseBodyRecords : TeaModel {
            /// <summary>
            /// at机器人消息数
            /// </summary>
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            /// <summary>
            /// 客户名称
            /// </summary>
            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 是否登录钉钉
            /// </summary>
            [NameInMap("hasLogin")]
            [Validation(Required=false)]
            public bool? HasLogin { get; set; }

            /// <summary>
            /// 是否打开群
            /// </summary>
            [NameInMap("hasOpenConv")]
            [Validation(Required=false)]
            public bool? HasOpenConv { get; set; }

            /// <summary>
            /// 发送消息数
            /// </summary>
            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            /// <summary>
            /// 开放用户ID
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 总数目
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
