// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryJobsResponseBodyList> List { get; set; }
        public class QueryJobsResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>职务描述</para>
            /// </summary>
            [NameInMap("jobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ac67286db74c48e28d787173ccc1a111</para>
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>总裁</para>
            /// </summary>
            [NameInMap("jobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
