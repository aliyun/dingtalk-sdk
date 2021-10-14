// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class QueryInterviewsResponseBody : TeaModel {
        /// <summary>
        /// 是否有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryInterviewsResponseBodyList> List { get; set; }
        public class QueryInterviewsResponseBodyList : TeaModel {
            /// <summary>
            /// 面试标识
            /// </summary>
            [NameInMap("interviewId")]
            [Validation(Required=false)]
            public string InterviewId { get; set; }

            /// <summary>
            /// 职位标识
            /// </summary>
            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 面试开始时间（单位：毫秒）
            /// </summary>
            [NameInMap("startTimeMillis")]
            [Validation(Required=false)]
            public long? StartTimeMillis { get; set; }

            /// <summary>
            /// 面试结束时间（单位：毫秒）
            /// </summary>
            [NameInMap("endTimeMillis")]
            [Validation(Required=false)]
            public long? EndTimeMillis { get; set; }

            /// <summary>
            /// 面试是否已取消
            /// </summary>
            [NameInMap("cancelled")]
            [Validation(Required=false)]
            public bool? Cancelled { get; set; }

            /// <summary>
            /// 面试创建人员工标识
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// 面试官列表
            /// </summary>
            [NameInMap("interviewers")]
            [Validation(Required=false)]
            public List<QueryInterviewsResponseBodyListInterviewers> Interviewers { get; set; }
            public class QueryInterviewsResponseBodyListInterviewers : TeaModel {
                /// <summary>
                /// 面试官员工标识
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        /// <summary>
        /// 下次查询的分页游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
