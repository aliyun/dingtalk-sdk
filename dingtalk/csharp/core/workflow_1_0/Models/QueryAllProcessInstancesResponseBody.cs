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
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryAllProcessInstancesResponseBodyResultList> List { get; set; }
            public class QueryAllProcessInstancesResponseBodyResultList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cdef-dae2fd2-example</para>
                /// </summary>
                [NameInMap("attachedProcessInstanceIds")]
                [Validation(Required=false)]
                public string AttachedProcessInstanceIds { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202110111558000355024</para>
                /// </summary>
                [NameInMap("businessId")]
                [Validation(Required=false)]
                public string BusinessId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635165470201</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1633795200000</para>
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public long? FinishTime { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("formComponentValues")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListFormComponentValues> FormComponentValues { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListFormComponentValues : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{&quot;staffId&quot;:&quot;abcd&quot;}</para>
                    /// </summary>
                    [NameInMap("extValue")]
                    [Validation(Required=false)]
                    public string ExtValue { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TextField-a32bcdef</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>姓名</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dcdse-dae2fd2-example</para>
                /// </summary>
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
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1234567</para>
                        /// </summary>
                        [NameInMap("fileId")]
                        [Validation(Required=false)]
                        public string FileId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>附件</para>
                        /// </summary>
                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>123</para>
                        /// </summary>
                        [NameInMap("fileSize")]
                        [Validation(Required=false)]
                        public string FileSize { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>pdf</para>
                        /// </summary>
                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public string FileType { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）</para>
                    /// </summary>
                    [NameInMap("operationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>同意</para>
                    /// </summary>
                    [NameInMap("remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AGREE（同意），REFUSE（拒绝），NONE（未知）</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1657522271000</para>
                    /// </summary>
                    [NameInMap("timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>manager1</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>默认-1，企业根部门</para>
                /// </summary>
                [NameInMap("originatorDeptId")]
                [Validation(Required=false)]
                public string OriginatorDeptId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>staff1234</para>
                /// </summary>
                [NameInMap("originatorUserid")]
                [Validation(Required=false)]
                public string OriginatorUserid { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdse-dse-example</para>
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGREE同意，REFUSE拒绝</para>
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING审批中、TERMINATED撤销、COMPLETED审批完成、CANCELED取消</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("tasks")]
                [Validation(Required=false)]
                public List<QueryAllProcessInstancesResponseBodyResultListTasks> Tasks { get; set; }
                public class QueryAllProcessInstancesResponseBodyResultListTasks : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1234_abcd</para>
                    /// </summary>
                    [NameInMap("activityId")]
                    [Validation(Required=false)]
                    public string ActivityId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1657522271000</para>
                    /// </summary>
                    [NameInMap("createTimestamp")]
                    [Validation(Required=false)]
                    public long? CreateTimestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1657522271000</para>
                    /// </summary>
                    [NameInMap("finishTimestamp")]
                    [Validation(Required=false)]
                    public long? FinishTimestamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>分为AGREE（同意），REFUSE（拒绝），REDIRECTED（转交）</para>
                    /// </summary>
                    [NameInMap("result")]
                    [Validation(Required=false)]
                    public string Result { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NEW（未启动），RUNNING（处理中），PAUSED（暂停），CANCELED（取消），COMPLETED（完成），TERMINATED（终止）</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("taskId")]
                    [Validation(Required=false)]
                    public long? TaskId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>staff1234</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>员工A提交的小肖审批单</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
