// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobRanksResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 职级列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryJobRanksResponseBodyList> List { get; set; }
        public class QueryJobRanksResponseBodyList : TeaModel {
            /// <summary>
            /// 最大等级
            /// </summary>
            [NameInMap("maxJobGrade")]
            [Validation(Required=false)]
            public int? MaxJobGrade { get; set; }

            /// <summary>
            /// 最小等级
            /// </summary>
            [NameInMap("minJobGrade")]
            [Validation(Required=false)]
            public int? MinJobGrade { get; set; }

            /// <summary>
            /// 职级序列ID
            /// </summary>
            [NameInMap("rankCategoryId")]
            [Validation(Required=false)]
            public string RankCategoryId { get; set; }

            /// <summary>
            /// 职级编码
            /// </summary>
            [NameInMap("rankCode")]
            [Validation(Required=false)]
            public string RankCode { get; set; }

            /// <summary>
            /// 职级描述
            /// </summary>
            [NameInMap("rankDescription")]
            [Validation(Required=false)]
            public string RankDescription { get; set; }

            /// <summary>
            /// 职级ID
            /// </summary>
            [NameInMap("rankId")]
            [Validation(Required=false)]
            public string RankId { get; set; }

            /// <summary>
            /// 职级名称
            /// </summary>
            [NameInMap("rankName")]
            [Validation(Required=false)]
            public string RankName { get; set; }

        }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
