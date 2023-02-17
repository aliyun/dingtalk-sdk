// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class QueryCorpUserStatisticResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCorpUserStatisticResponseBodyList> List { get; set; }
        public class QueryCorpUserStatisticResponseBodyList : TeaModel {
            /// <summary>
            /// 用户头像
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public string AvatarUrl { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 收下数
            /// </summary>
            [NameInMap("receiveCnt")]
            [Validation(Required=false)]
            public long? ReceiveCnt { get; set; }

            /// <summary>
            /// 发送数
            /// </summary>
            [NameInMap("sendCnt")]
            [Validation(Required=false)]
            public long? SendCnt { get; set; }

            /// <summary>
            /// 用户id
            /// 
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

        /// <summary>
        /// 下一游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
