// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllProcessInstancesResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryAllProcessInstancesResponseBodyResult Result { get; set; }
        public class QueryAllProcessInstancesResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryAllProcessInstancesResponseBodyResultList> List { get; set; }
            public class QueryAllProcessInstancesResponseBodyResultList : TeaModel {
                public string AttachedProcessInstanceIds { get; set; }
                public string BusinessId { get; set; }
                public long? CreateTime { get; set; }
                public long? FinishTime { get; set; }
                public List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> FormComponentValues { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListFormComponentValues : TeaModel {
                    public string ExtValue { get; set; }
                    public string Id { get; set; }
                    public string Name { get; set; }
                    public string Value { get; set; }
                }
                public string MainProcessInstanceId { get; set; }
                public List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> OperationRecords { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListOperationRecords : TeaModel {
                    public List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> Attachments { get; set; }
                    public class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments : TeaModel {
                        public string FileId { get; set; }
                        public string FileName { get; set; }
                        public string FileSize { get; set; }
                        public string FileType { get; set; }
                    }
                    public string OperationType { get; set; }
                    public string Remark { get; set; }
                    public string Result { get; set; }
                    public long? Timestamp { get; set; }
                    public string UserId { get; set; }
                }
                public string OriginatorDeptId { get; set; }
                public string OriginatorUserid { get; set; }
                public string ProcessInstanceId { get; set; }
                public string Result { get; set; }
                public string Status { get; set; }
                public List<QueryAllProcessInstancesResponseBodyResultListTasks> Tasks { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListTasks : TeaModel {
                    public string ActivityId { get; set; }
                    public long? CreateTimestamp { get; set; }
                    public long? FinishTimestamp { get; set; }
                    public string Result { get; set; }
                    public string Status { get; set; }
                    public long? TaskId { get; set; }
                    public string UserId { get; set; }
                }
                public string Title { get; set; }
            }
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
