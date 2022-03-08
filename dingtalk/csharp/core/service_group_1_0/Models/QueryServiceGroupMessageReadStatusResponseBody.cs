// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryServiceGroupMessageReadStatusResponseBody : TeaModel {
        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 已读未读信息列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryServiceGroupMessageReadStatusResponseBodyRecords> Records { get; set; }
        public class QueryServiceGroupMessageReadStatusResponseBodyRecords : TeaModel {
            /// <summary>
            /// 状态：已读1/未读0
            /// </summary>
            [NameInMap("readStatus")]
            [Validation(Required=false)]
            public int? ReadStatus { get; set; }

            /// <summary>
            /// 已读时间
            /// </summary>
            [NameInMap("readTimeStr")]
            [Validation(Required=false)]
            public string ReadTimeStr { get; set; }

            /// <summary>
            /// 接收者dingtalkId
            /// </summary>
            [NameInMap("receiverDingTalkId")]
            [Validation(Required=false)]
            public string ReceiverDingTalkId { get; set; }

            /// <summary>
            /// 接收者昵称
            /// </summary>
            [NameInMap("receiverName")]
            [Validation(Required=false)]
            public string ReceiverName { get; set; }

            /// <summary>
            /// 已读人员为非企业员工则有值
            /// </summary>
            [NameInMap("receiverUnionId")]
            [Validation(Required=false)]
            public string ReceiverUnionId { get; set; }

            /// <summary>
            /// 已读人员为企业员工则有值
            /// </summary>
            [NameInMap("receiverUserId")]
            [Validation(Required=false)]
            public string ReceiverUserId { get; set; }

            /// <summary>
            /// 发送时间
            /// </summary>
            [NameInMap("sendTimeStr")]
            [Validation(Required=false)]
            public string SendTimeStr { get; set; }

        }

        /// <summary>
        /// 本次请求条件下的数据总量，此参数为可选参数，默认可不返回。本次请求条件下的数据总量，此参数为可选参数，默认可不返回
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
