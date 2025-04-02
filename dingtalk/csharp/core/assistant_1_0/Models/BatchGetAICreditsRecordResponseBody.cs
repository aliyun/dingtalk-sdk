// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class BatchGetAICreditsRecordResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<BatchGetAICreditsRecordResponseBodyList> List { get; set; }
        public class BatchGetAICreditsRecordResponseBodyList : TeaModel {
            [NameInMap("actionNames")]
            [Validation(Required=false)]
            public string ActionNames { get; set; }

            [NameInMap("assistantId")]
            [Validation(Required=false)]
            public string AssistantId { get; set; }

            [NameInMap("assistantName")]
            [Validation(Required=false)]
            public string AssistantName { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("usedNum")]
            [Validation(Required=false)]
            public double? UsedNum { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
