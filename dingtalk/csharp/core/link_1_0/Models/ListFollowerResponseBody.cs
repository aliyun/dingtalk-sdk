// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ListFollowerResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListFollowerResponseBodyResult Result { get; set; }
        public class ListFollowerResponseBodyResult : TeaModel {
            /// <summary>
            /// 下一页查询位置
            /// 当此返回值为空时，则说明全部数据查询完成。
            /// 当此返回值不为空时，可以将此值设置为下一次查询的参数。
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// 用户列表
            /// </summary>
            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<ListFollowerResponseBodyResultUserList> UserList { get; set; }
            public class ListFollowerResponseBodyResultUserList : TeaModel {
                /// <summary>
                /// 关注者昵称
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 关注时间 
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// 关注者userId，可用于消息推送等场景。
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
