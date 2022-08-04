// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListFeedsResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据。
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 动态列表。
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListFeedsResponseBodyItems> Items { get; set; }
        public class ListFeedsResponseBodyItems : TeaModel {
            /// <summary>
            /// 动态内容。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 动态时间。
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            /// <summary>
            /// 动态类型。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// 分页游标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
