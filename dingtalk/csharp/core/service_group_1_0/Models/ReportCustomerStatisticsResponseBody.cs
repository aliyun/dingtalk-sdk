// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ReportCustomerStatisticsResponseBody : TeaModel {
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
        public List<ReportCustomerStatisticsResponseBodyRecords> Records { get; set; }
        public class ReportCustomerStatisticsResponseBodyRecords : TeaModel {
            /// <summary>
            /// at机器人消息数
            /// </summary>
            [NameInMap("atRobotCnt")]
            [Validation(Required=false)]
            public long? AtRobotCnt { get; set; }

            /// <summary>
            /// 业务ID
            /// </summary>
            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// 客户数
            /// </summary>
            [NameInMap("customerCnt")]
            [Validation(Required=false)]
            public long? CustomerCnt { get; set; }

            /// <summary>
            /// 群名称
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// 群分组名称
            /// </summary>
            [NameInMap("groupSetName")]
            [Validation(Required=false)]
            public string GroupSetName { get; set; }

            /// <summary>
            /// 打开钉钉客户数
            /// </summary>
            [NameInMap("loginCnt")]
            [Validation(Required=false)]
            public long? LoginCnt { get; set; }

            /// <summary>
            /// 打开群客户数
            /// </summary>
            [NameInMap("openConvCnt")]
            [Validation(Required=false)]
            public long? OpenConvCnt { get; set; }

            /// <summary>
            /// 开放群ID
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// 开放群分组ID
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// 发送消息数
            /// </summary>
            [NameInMap("sendMsgCnt")]
            [Validation(Required=false)]
            public long? SendMsgCnt { get; set; }

            /// <summary>
            /// 发消息的客户数
            /// </summary>
            [NameInMap("senderCnt")]
            [Validation(Required=false)]
            public long? SenderCnt { get; set; }

        }

        /// <summary>
        /// 总数目
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
