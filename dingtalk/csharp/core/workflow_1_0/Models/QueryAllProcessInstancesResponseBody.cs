// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryAllProcessInstancesResponseBody : TeaModel {
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
                [NameInMap("attachedProcessInstanceIds")]
                [Validation(Required=false)]
                public string AttachedProcessInstanceIds { get; set; }

                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("formComponentValues")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> FormComponentValues { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListFormComponentValues : TeaModel {
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("mainProcessInstanceId")]
                [Validation(Required=false)]
                public string MainProcessInstanceId { get; set; }

                [NameInMap("operationRecords")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> OperationRecords { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListOperationRecords : TeaModel {
                    [NameInMap("attachments")]
                    [Validation(Required=false)]
                    public List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> Attachments { get; set; }
                    public class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments : TeaModel {
                        [NameInMap("fileId")]
                        [Validation(Required=false)]
                        public string FileId { get; set; }

                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("fileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }

                    }

                    [NameInMap("operationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("originatorDeptId")]
                [Validation(Required=false)]
                public string OriginatorDeptId { get; set; }

                [NameInMap("originatorUserid")]
                [Validation(Required=false)]
                public string OriginatorUserid { get; set; }

                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("tasks")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListTasks> Tasks { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListTasks : TeaModel {
                    [NameInMap("activityId")]
                    [Validation(Required=false)]
                    public string ActivityId { get; set; }

                    [NameInMap("createTimestamp")]
                    [Validation(Required=false)]
                    public long? CreateTimestamp { get; set; }

                    [NameInMap("finishTimestamp")]
                    [Validation(Required=false)]
                    public long? FinishTimestamp { get; set; }

                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("taskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
