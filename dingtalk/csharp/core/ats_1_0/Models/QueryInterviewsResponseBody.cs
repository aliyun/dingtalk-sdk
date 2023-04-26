// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class QueryInterviewsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryInterviewsResponseBodyList> List { get; set; }
        public class QueryInterviewsResponseBodyList : TeaModel {
            [NameInMap("cancelled")]
            [Validation(Required=false)]
            public bool? Cancelled { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("endTimeMillis")]
            [Validation(Required=false)]
            public long? EndTimeMillis { get; set; }

            [NameInMap("interviewId")]
            [Validation(Required=false)]
            public string InterviewId { get; set; }

            [NameInMap("interviewers")]
            [Validation(Required=false)]
            public List<QueryInterviewsResponseBodyListInterviewers> Interviewers { get; set; }
            public class QueryInterviewsResponseBodyListInterviewers : TeaModel {
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("jobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("startTimeMillis")]
            [Validation(Required=false)]
            public long? StartTimeMillis { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
