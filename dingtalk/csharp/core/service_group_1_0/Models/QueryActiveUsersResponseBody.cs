// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryActiveUsersResponseBody : TeaModel {
        /// <summary>
        /// 活跃用户列表
        /// </summary>
        [NameInMap("activeUserInfos")]
        [Validation(Required=false)]
        public List<QueryActiveUsersResponseBodyActiveUserInfos> ActiveUserInfos { get; set; }
        public class QueryActiveUsersResponseBodyActiveUserInfos : TeaModel {
            /// <summary>
            /// 钉钉用户unionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 昵称
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 最近一周的行为指数
            /// </summary>
            [NameInMap("actionIndexL7d")]
            [Validation(Required=false)]
            public double? ActionIndexL7d { get; set; }

            /// <summary>
            /// 最近二周的行为指数
            /// </summary>
            [NameInMap("actionIndexL14d")]
            [Validation(Required=false)]
            public double? ActionIndexL14d { get; set; }

            /// <summary>
            /// 最近一个月的行为指数
            /// </summary>
            [NameInMap("actionIndexL30d")]
            [Validation(Required=false)]
            public double? ActionIndexL30d { get; set; }

            /// <summary>
            /// 活跃度
            /// </summary>
            [NameInMap("activeScore")]
            [Validation(Required=false)]
            public double? ActiveScore { get; set; }

            /// <summary>
            /// 排名
            /// </summary>
            [NameInMap("ranking")]
            [Validation(Required=false)]
            public long? Ranking { get; set; }

        }

    }

}
