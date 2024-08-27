// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumGetProcessInstancesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumGetProcessInstancesResponseBodyResult Result { get; set; }
        public class PremiumGetProcessInstancesResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<PremiumGetProcessInstancesResponseBodyResultList> List { get; set; }
            public class PremiumGetProcessInstancesResponseBodyResultList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("attachedProcessInstanceIds")]
                [Validation(Required=false)]
                public string AttachedProcessInstanceIds { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("formComponentValues")]
                [Validation(Required=false)]
                public List<PremiumGetProcessInstancesResponseBodyResultListFormComponentValues> FormComponentValues { get; set; }
                public class PremiumGetProcessInstancesResponseBodyResultListFormComponentValues : TeaModel {
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("mainProcessInstanceId")]
                [Validation(Required=false)]
                public string MainProcessInstanceId { get; set; }

                [NameInMap("operationRecords")]
                [Validation(Required=false)]
                public List<PremiumGetProcessInstancesResponseBodyResultListOperationRecords> OperationRecords { get; set; }
                public class PremiumGetProcessInstancesResponseBodyResultListOperationRecords : TeaModel {
                    [NameInMap("attachments")]
                    [Validation(Required=false)]
                    public List<PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments> Attachments { get; set; }
                    public class PremiumGetProcessInstancesResponseBodyResultListOperationRecordsAttachments : TeaModel {
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

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("originatorDeptId")]
                [Validation(Required=false)]
                public string OriginatorDeptId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("originatorUserid")]
                [Validation(Required=false)]
                public string OriginatorUserid { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("tasks")]
                [Validation(Required=false)]
                public List<PremiumGetProcessInstancesResponseBodyResultListTasks> Tasks { get; set; }
                public class PremiumGetProcessInstancesResponseBodyResultListTasks : TeaModel {
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

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("taskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
