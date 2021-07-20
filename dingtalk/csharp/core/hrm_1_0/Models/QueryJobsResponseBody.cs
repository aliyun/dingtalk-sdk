// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobsResponseBody : TeaModel {
        /// <summary>
        /// 下次获取数据的起始游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 职务列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryJobsResponseBodyList> List { get; set; }
        public class QueryJobsResponseBodyList : TeaModel {
            /// <summary>
            /// 职务ID
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 职务名称
            /// </summary>
            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// 职务描述
            /// </summary>
            [NameInMap("jobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

        }

    }

}
