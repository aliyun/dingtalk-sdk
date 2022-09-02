// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastResponseBody : TeaModel {
        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessForecastResponseBodyResult Result { get; set; }
        public class ProcessForecastResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否预测成功
            /// </summary>
            [NameInMap("isForecastSuccess")]
            [Validation(Required=false)]
            public bool? IsForecastSuccess { get; set; }

            /// <summary>
            /// 是否静态流程
            /// </summary>
            [NameInMap("isStaticWorkflow")]
            [Validation(Required=false)]
            public bool? IsStaticWorkflow { get; set; }

            /// <summary>
            /// 流程 code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// 流程 id
            /// </summary>
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// 用户 id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workflowActivityRules")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowActivityRules> WorkflowActivityRules { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowActivityRules : TeaModel {
                /// <summary>
                /// 节点 id
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// 节点名称
                /// </summary>
                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// 规则类型
                /// </summary>
                [NameInMap("activityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                /// <summary>
                /// 是否自选审批节点
                /// </summary>
                [NameInMap("isTargetSelect")]
                [Validation(Required=false)]
                public bool? IsTargetSelect { get; set; }

                /// <summary>
                /// 流程中前一个节点的 id
                /// </summary>
                [NameInMap("prevActivityId")]
                [Validation(Required=false)]
                public string PrevActivityId { get; set; }

                /// <summary>
                /// 节点操作人信息
                /// </summary>
                [NameInMap("workflowActor")]
                [Validation(Required=false)]
                public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor WorkflowActor { get; set; }
                public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor : TeaModel {
                    /// <summary>
                    /// 节点激活类型
                    /// </summary>
                    [NameInMap("actorActivateType")]
                    [Validation(Required=false)]
                    public string ActorActivateType { get; set; }

                    /// <summary>
                    /// 节点操作人 key
                    /// </summary>
                    [NameInMap("actorKey")]
                    [Validation(Required=false)]
                    public string ActorKey { get; set; }

                    /// <summary>
                    /// 节点操作人选择范围
                    /// </summary>
                    [NameInMap("actorSelectionRange")]
                    [Validation(Required=false)]
                    public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange ActorSelectionRange { get; set; }
                    public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange : TeaModel {
                        /// <summary>
                        /// 审批指定成员
                        /// </summary>
                        [NameInMap("approvals")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> Approvals { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals : TeaModel {
                            /// <summary>
                            /// 员工姓名
                            /// </summary>
                            [NameInMap("userName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                            /// <summary>
                            /// 员工 userId
                            /// </summary>
                            [NameInMap("workNo")]
                            [Validation(Required=false)]
                            public string WorkNo { get; set; }

                        }

                        /// <summary>
                        /// 审批指定角色
                        /// </summary>
                        [NameInMap("labels")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> Labels { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels : TeaModel {
                            /// <summary>
                            /// 角色名字
                            /// </summary>
                            [NameInMap("labelNames")]
                            [Validation(Required=false)]
                            public string LabelNames { get; set; }

                            /// <summary>
                            /// 角色 id
                            /// </summary>
                            [NameInMap("labels")]
                            [Validation(Required=false)]
                            public string Labels { get; set; }

                        }

                    }

                    /// <summary>
                    /// 节点操作人选择范围类型
                    /// </summary>
                    [NameInMap("actorSelectionType")]
                    [Validation(Required=false)]
                    public string ActorSelectionType { get; set; }

                    /// <summary>
                    /// 节点操作人类型
                    /// </summary>
                    [NameInMap("actorType")]
                    [Validation(Required=false)]
                    public string ActorType { get; set; }

                    /// <summary>
                    /// 是否允许多选，还是仅允许选一人
                    /// </summary>
                    [NameInMap("allowedMulti")]
                    [Validation(Required=false)]
                    public bool? AllowedMulti { get; set; }

                    /// <summary>
                    /// 节点审批方式
                    /// </summary>
                    [NameInMap("approvalMethod")]
                    [Validation(Required=false)]
                    public string ApprovalMethod { get; set; }

                    /// <summary>
                    /// 节点审批类型
                    /// </summary>
                    [NameInMap("approvalType")]
                    [Validation(Required=false)]
                    public string ApprovalType { get; set; }

                    /// <summary>
                    /// 该审批人节点在发起审批时是否必填
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

            }

            [NameInMap("workflowForecastNodes")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowForecastNodes> WorkflowForecastNodes { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowForecastNodes : TeaModel {
                /// <summary>
                /// 节点 id
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// 节点出线 id
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

            }

        }

    }

}
