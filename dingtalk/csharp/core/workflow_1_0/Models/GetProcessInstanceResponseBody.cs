// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessInstanceResponseBodyResult Result { get; set; }
        public class GetProcessInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// 审批人userid列表。
            /// </summary>
            [NameInMap("approverUserIds")]
            [Validation(Required=false)]
            public List<string> ApproverUserIds { get; set; }

            /// <summary>
            /// 审批附属实例列表，当已经通过的审批实例被修改或撤销，会生成一个新的实例，作为原有审批实例的附属。  如果想知道当前已经通过的审批实例的状态，可以依次遍历它的附属列表，查询里面每个实例的biz_action。
            /// </summary>
            [NameInMap("attachedProcessInstanceIds")]
            [Validation(Required=false)]
            public List<string> AttachedProcessInstanceIds { get; set; }

            /// <summary>
            /// 审批实例业务动作：  MODIFY：表示该审批实例是基于原来的实例修改而来  REVOKE：表示该审批实例是由原来的实例撤销后重新发起的  NONE表示正常发起
            /// </summary>
            [NameInMap("bizAction")]
            [Validation(Required=false)]
            public string BizAction { get; set; }

            /// <summary>
            /// 审批实例业务编号。
            /// </summary>
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// 抄送人userid列表。
            /// </summary>
            [NameInMap("ccUserIds")]
            [Validation(Required=false)]
            public List<string> CcUserIds { get; set; }

            /// <summary>
            /// 创建时间。
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 结束时间。
            /// </summary>
            [NameInMap("finishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// 表单详情列表。
            /// </summary>
            [NameInMap("formComponentValues")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultFormComponentValues> FormComponentValues { get; set; }
            public class GetProcessInstanceResponseBodyResultFormComponentValues : TeaModel {
                /// <summary>
                /// 组件别名。
                /// </summary>
                [NameInMap("bizAlias")]
                [Validation(Required=false)]
                public string BizAlias { get; set; }

                /// <summary>
                /// 组件类型。
                /// </summary>
                [NameInMap("componentType")]
                [Validation(Required=false)]
                public string ComponentType { get; set; }

                /// <summary>
                /// 标签扩展值。
                /// </summary>
                [NameInMap("extValue")]
                [Validation(Required=false)]
                public string ExtValue { get; set; }

                /// <summary>
                /// 组件ID。
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 组件名称。
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 标签值。
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 主流程实例标识。
            /// </summary>
            [NameInMap("mainProcessInstanceId")]
            [Validation(Required=false)]
            public string MainProcessInstanceId { get; set; }

            /// <summary>
            /// 操作记录列表。
            /// </summary>
            [NameInMap("operationRecords")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultOperationRecords> OperationRecords { get; set; }
            public class GetProcessInstanceResponseBodyResultOperationRecords : TeaModel {
                /// <summary>
                /// 评论附件列表。
                /// </summary>
                [NameInMap("attachments")]
                [Validation(Required=false)]
                public List<GetProcessInstanceResponseBodyResultOperationRecordsAttachments> Attachments { get; set; }
                public class GetProcessInstanceResponseBodyResultOperationRecordsAttachments : TeaModel {
                    /// <summary>
                    /// 附件ID。
                    /// </summary>
                    [NameInMap("fileId")]
                    [Validation(Required=false)]
                    public string FileId { get; set; }

                    /// <summary>
                    /// 附件名称。
                    /// </summary>
                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// 附件大小。
                    /// </summary>
                    [NameInMap("fileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// 附件类型。
                    /// </summary>
                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                }

                /// <summary>
                /// 操作时间。
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// 评论内容。  审批操作附带评论时才返回该字段。
                /// </summary>
                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 操作结果：  AGREE：同意  REFUSE：拒绝  NONE
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// 操作类型：  EXECUTE_TASK_NORMAL：正常执行任务  EXECUTE_TASK_AGENT：代理人执行任务  APPEND_TASK_BEFORE：前加签任务  APPEND_TASK_AFTER：后加签任务  REDIRECT_TASK：转交任务  START_PROCESS_INSTANCE：发起流程实例  TERMINATE_PROCESS_INSTANCE：终止(撤销)流程实例  FINISH_PROCESS_INSTANCE：结束流程实例  ADD_REMARK：添加评论  REDIRECT_PROCESS：审批退回  PROCESS_CC：抄送
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// 操作人userid。
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 发起人的部门。-1表示根部门。
            /// </summary>
            [NameInMap("originatorDeptId")]
            [Validation(Required=false)]
            public string OriginatorDeptId { get; set; }

            /// <summary>
            /// 发起人的部门名。
            /// </summary>
            [NameInMap("originatorDeptName")]
            [Validation(Required=false)]
            public string OriginatorDeptName { get; set; }

            /// <summary>
            /// 发起人的userid。
            /// </summary>
            [NameInMap("originatorUserId")]
            [Validation(Required=false)]
            public string OriginatorUserId { get; set; }

            /// <summary>
            /// 审批结果：  agree：同意  refuse：拒绝。 说明 status为COMPLETED且result为同意时，表示审批单完结并审批通过。
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// 审批状态：  NEW：新创建  RUNNING：审批中  TERMINATED：被终止  COMPLETED：完成  CANCELED：取消
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 任务列表。
            /// </summary>
            [NameInMap("tasks")]
            [Validation(Required=false)]
            public List<GetProcessInstanceResponseBodyResultTasks> Tasks { get; set; }
            public class GetProcessInstanceResponseBodyResultTasks : TeaModel {
                /// <summary>
                /// 任务节点ID。
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// 开始时间。
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// 结束时间。
                /// </summary>
                [NameInMap("finishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// 移动端任务URL。
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// PC端任务URL。
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                /// <summary>
                /// 实例ID。
                /// </summary>
                [NameInMap("processInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// 结果：  AGREE：同意  REFUSE：拒绝  REDIRECTED：转交
                /// </summary>
                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                /// <summary>
                /// 任务状态：  NEW：未启动  RUNNING：处理中  PAUSED：暂停  CANCELED：取消  COMPLETED：完成  TERMINATED：终止
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// 任务ID。
                /// </summary>
                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// 任务处理人。
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 审批实例标题。
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 调用是否成功。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
