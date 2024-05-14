// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQuerySendMessageTaskResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<BatchQuerySendMessageTaskResponseBodyRecords> Records { get; set; }
        public class BatchQuerySendMessageTaskResponseBodyRecords : TeaModel {
            [NameInMap("createName")]
            [Validation(Required=false)]
            public string CreateName { get; set; }

            [NameInMap("createTimeStr")]
            [Validation(Required=false)]
            public string CreateTimeStr { get; set; }

            [NameInMap("createUnionId")]
            [Validation(Required=false)]
            public string CreateUnionId { get; set; }

            [NameInMap("openBatchTaskId")]
            [Validation(Required=false)]
            public string OpenBatchTaskId { get; set; }

            [NameInMap("readGroupInc")]
            [Validation(Required=false)]
            public long? ReadGroupInc { get; set; }

            [NameInMap("sendGroupInc")]
            [Validation(Required=false)]
            public long? SendGroupInc { get; set; }

            [NameInMap("sendMessageStatus")]
            [Validation(Required=false)]
            public string SendMessageStatus { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sendTaskTimeStr")]
            [Validation(Required=false)]
            public string SendTaskTimeStr { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public float? TotalCount { get; set; }

    }

}
