// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryCustomerSendTaskResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("records")]
        [Validation(Required=false)]
        public List<BatchQueryCustomerSendTaskResponseBodyRecords> Records { get; set; }
        public class BatchQueryCustomerSendTaskResponseBodyRecords : TeaModel {
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

            [NameInMap("readCustomerInc")]
            [Validation(Required=false)]
            public long? ReadCustomerInc { get; set; }

            [NameInMap("readUserInc")]
            [Validation(Required=false)]
            public long? ReadUserInc { get; set; }

            [NameInMap("sendCustomerInc")]
            [Validation(Required=false)]
            public long? SendCustomerInc { get; set; }

            [NameInMap("sendMessageStatus")]
            [Validation(Required=false)]
            public string SendMessageStatus { get; set; }

            [NameInMap("sendTaskTimeStr")]
            [Validation(Required=false)]
            public string SendTaskTimeStr { get; set; }

            [NameInMap("sendUserInc")]
            [Validation(Required=false)]
            public long? SendUserInc { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
