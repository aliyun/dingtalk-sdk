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
            [NameInMap("isForecastSuccess")]
            [Validation(Required=false)]
            public bool? IsForecastSuccess { get; set; }
            [NameInMap("isStaticWorkflow")]
            [Validation(Required=false)]
            public bool? IsStaticWorkflow { get; set; }
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("workflowActivityRules")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowActivityRules> WorkflowActivityRules { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowActivityRules : TeaModel {
                public string ActivityId { get; set; }
                public string PrevActivityId { get; set; }
                public string ActivityName { get; set; }
                public string ActivityType { get; set; }
                public bool? IsTargetSelect { get; set; }
                public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor WorkflowActor { get; set; }
                public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor : TeaModel {
                    /// <summary>
                    /// 节点操作人 key
                    /// </summary>
                    [NameInMap("actorKey")]
                    [Validation(Required=false)]
                    public string ActorKey { get; set; }

                    /// <summary>
                    /// 节点操作人类型
                    /// </summary>
                    [NameInMap("actorType")]
                    [Validation(Required=false)]
                    public string ActorType { get; set; }

                    /// <summary>
                    /// 节点操作人选择范围类型
                    /// </summary>
                    [NameInMap("actorSelectionType")]
                    [Validation(Required=false)]
                    public string ActorSelectionType { get; set; }

                    /// <summary>
                    /// 节点操作人选择范围
                    /// </summary>
                    [NameInMap("actorSelectionRange")]
                    [Validation(Required=false)]
                    public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange ActorSelectionRange { get; set; }
                    public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange : TeaModel {
                        [NameInMap("approvals")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> Approvals { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals : TeaModel {
                            public string WorkNo { get; set; }
                            public string UserName { get; set; }
                        }
                        [NameInMap("labels")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> Labels { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels : TeaModel {
                            public string Labels { get; set; }
                            public string LabelNames { get; set; }
                        }
                    };

                    /// <summary>
                    /// 是否允许多选，还是仅允许选一人
                    /// </summary>
                    [NameInMap("allowedMulti")]
                    [Validation(Required=false)]
                    public bool? AllowedMulti { get; set; }

                    /// <summary>
                    /// 节点审批类型
                    /// </summary>
                    [NameInMap("approvalType")]
                    [Validation(Required=false)]
                    public string ApprovalType { get; set; }

                    /// <summary>
                    /// 节点审批方式
                    /// </summary>
                    [NameInMap("approvalMethod")]
                    [Validation(Required=false)]
                    public string ApprovalMethod { get; set; }

                    /// <summary>
                    /// 节点激活类型
                    /// </summary>
                    [NameInMap("actorActivateType")]
                    [Validation(Required=false)]
                    public string ActorActivateType { get; set; }

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
                public string ActivityId { get; set; }
                public string OutId { get; set; }
            }
        };

    }

}
