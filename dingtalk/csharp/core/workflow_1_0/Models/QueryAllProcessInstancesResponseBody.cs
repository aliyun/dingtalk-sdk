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
            /// <summary>
            /// 是否有更多数据
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryAllProcessInstancesResponseBodyResultList> List { get; set; }
            public class QueryAllProcessInstancesResponseBodyResultList : TeaModel {
                /// <summary>
                /// 附属单信息
                /// </summary>
                [NameInMap("attachedProcessInstanceIds")]
                [Validation(Required=false)]
                public string AttachedProcessInstanceIds { get; set; }

                /// <summary>
                /// 审批单编号
                /// </summary>
                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                /// <summary>
                /// 审批单创建时间
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// 审批结束时间
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                [NameInMap("formComponentValues")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> FormComponentValues { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListFormComponentValues : TeaModel {
                    /// <summary>
                    /// 控件扩展数据
                    /// </summary>
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    /// <summary>
                    /// 控件id
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// 控件名称
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// 控件数据
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// 主单实例Id
                /// </summary>
                [NameInMap("mainProcessInstanceId")]
                [Validation(Required=false)]
                public string MainProcessInstanceId { get; set; }

                /// <summary>
                /// 审批单操作记录
                /// </summary>
                [NameInMap("operationRecords")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListOperationRecords> OperationRecords { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListOperationRecords : TeaModel {
                    /// <summary>
                    /// 评论附件
                    /// </summary>
                    [NameInMap("attachments")]
                    [Validation(Required=false)]
                    public List<QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments> Attachments { get; set; }
                    public class QueryAllProcessInstancesResponseBodyResultListOperationRecordsAttachments : TeaModel {
                        /// <summary>
                        /// 附件钉盘id
                        /// </summary>
                        [NameInMap("fileId")]
                        [Validation(Required=false)]
                        public string FileId { get; set; }

                        /// <summary>
                        /// 附件名称
                        /// </summary>
                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// 文件大小
                        /// </summary>
                        [NameInMap("fileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// 文件类型
                        /// </summary>
                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }

                    }

                    /// <summary>
                    /// 操作类型
                    /// </summary>
                    [NameInMap("operationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    /// <summary>
                    /// 评论
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// 操作结果
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// 操作时间戳
                    /// </summary>
                    [NameInMap("timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// 操作人staffId
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 发起人部门id
                /// </summary>
                [NameInMap("originatorDeptId")]
                [Validation(Required=false)]
                public string OriginatorDeptId { get; set; }

                /// <summary>
                /// 发起者userId
                /// </summary>
                [NameInMap("originatorUserid")]
                [Validation(Required=false)]
                public string OriginatorUserid { get; set; }

                /// <summary>
                /// 流程实例ID
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// 审批结果
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// 审批单状态
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 任务列表
                /// </summary>
                [NameInMap("tasks")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListTasks> Tasks { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListTasks : TeaModel {
                    /// <summary>
                    /// 节点id
                    /// </summary>
                    [NameInMap("activityId")]
                    [Validation(Required=false)]
                    public string ActivityId { get; set; }

                    /// <summary>
                    /// 任务创建时间戳
                    /// </summary>
                    [NameInMap("createTimestamp")]
                    [Validation(Required=false)]
                    public long? CreateTimestamp { get; set; }

                    /// <summary>
                    /// 任务结束时间戳
                    /// </summary>
                    [NameInMap("finishTimestamp")]
                    [Validation(Required=false)]
                    public long? FinishTimestamp { get; set; }

                    /// <summary>
                    /// 任务结果
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// 任务状态
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// 任务Id
                    /// </summary>
                    [NameInMap("taskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    /// <summary>
                    /// 任务处理人
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// 审批单标题
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// 总数
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// 下次获取数据的游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
