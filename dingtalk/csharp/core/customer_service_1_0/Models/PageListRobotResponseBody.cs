// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcustomer_service_1_0.Models
{
    public class PageListRobotResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多结果
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 查询结果列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PageListRobotResponseBodyList> List { get; set; }
        public class PageListRobotResponseBodyList : TeaModel {
            /// <summary>
            /// 机器人所在租户ID
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            /// <summary>
            /// 机器人APPKEY
            /// </summary>
            [NameInMap("appKey")]
            [Validation(Required=false)]
            public string AppKey { get; set; }

            /// <summary>
            /// 机器人自增Id
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 机器人名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 机器人状态
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// 下一次查询起始游标
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// 查询结果总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
