// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryProjectByPageResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// resultList
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryProjectByPageResponseBodyList> List { get; set; }
        public class QueryProjectByPageResponseBodyList : TeaModel {
            /// <summary>
            /// 项目code
            /// </summary>
            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// 项目名称
            /// </summary>
            [NameInMap("projectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 创建人工号
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 状态: valid, invalid, deleted
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 企业id
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

        }

    }

}
