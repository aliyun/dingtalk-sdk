// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryPositionsResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 职位列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryPositionsResponseBodyList> List { get; set; }
        public class QueryPositionsResponseBodyList : TeaModel {
            /// <summary>
            /// 所属职务ID
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 职位类别ID
            /// </summary>
            [NameInMap("positionCategoryId")]
            [Validation(Required=false)]
            public string PositionCategoryId { get; set; }

            /// <summary>
            /// 职位描述
            /// </summary>
            [NameInMap("positionDes")]
            [Validation(Required=false)]
            public string PositionDes { get; set; }

            /// <summary>
            /// 职位ID
            /// </summary>
            [NameInMap("positionId")]
            [Validation(Required=false)]
            public string PositionId { get; set; }

            /// <summary>
            /// 职位名称
            /// </summary>
            [NameInMap("positionName")]
            [Validation(Required=false)]
            public string PositionName { get; set; }

            /// <summary>
            /// 职位对应职级列表
            /// </summary>
            [NameInMap("rankIdList")]
            [Validation(Required=false)]
            public List<string> RankIdList { get; set; }

            /// <summary>
            /// 职位状态-0，启用；1，停用
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// 表示当前调用返回读取到的位置，空代表数据已经读取完毕
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
