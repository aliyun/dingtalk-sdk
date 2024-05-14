// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ProcessForecastResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessForecastResponseBodyResult Result { get; set; }
        public class ProcessForecastResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isForecastSuccess")]
            [Validation(Required=false)]
            public bool? IsForecastSuccess { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("isStaticWorkflow")]
            [Validation(Required=false)]
            public bool? IsStaticWorkflow { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workflowActivityRules")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowActivityRules> WorkflowActivityRules { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowActivityRules : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("activityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                [NameInMap("isTargetSelect")]
                [Validation(Required=false)]
                public bool? IsTargetSelect { get; set; }

                [NameInMap("prevActivityId")]
                [Validation(Required=false)]
                public string PrevActivityId { get; set; }

                [NameInMap("workflowActor")]
                [Validation(Required=false)]
                public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor WorkflowActor { get; set; }
                public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor : TeaModel {
                    [NameInMap("actorActivateType")]
                    [Validation(Required=false)]
                    public string ActorActivateType { get; set; }

                    [NameInMap("actorKey")]
                    [Validation(Required=false)]
                    public string ActorKey { get; set; }

                    [NameInMap("actorSelectionRange")]
                    [Validation(Required=false)]
                    public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange ActorSelectionRange { get; set; }
                    public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRange : TeaModel {
                        [NameInMap("approvals")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals> Approvals { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeApprovals : TeaModel {
                            [NameInMap("userName")]
                            [Validation(Required=false)]
                            public string UserName { get; set; }

                            [NameInMap("workNo")]
                            [Validation(Required=false)]
                            public string WorkNo { get; set; }

                        }

                        [NameInMap("labels")]
                        [Validation(Required=false)]
                        public List<ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels> Labels { get; set; }
                        public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActorActorSelectionRangeLabels : TeaModel {
                            [NameInMap("labelNames")]
                            [Validation(Required=false)]
                            public string LabelNames { get; set; }

                            [NameInMap("labels")]
                            [Validation(Required=false)]
                            public string Labels { get; set; }

                        }

                    }

                    [NameInMap("actorSelectionType")]
                    [Validation(Required=false)]
                    public string ActorSelectionType { get; set; }

                    [NameInMap("actorType")]
                    [Validation(Required=false)]
                    public string ActorType { get; set; }

                    [NameInMap("allowedMulti")]
                    [Validation(Required=false)]
                    public bool? AllowedMulti { get; set; }

                    [NameInMap("approvalMethod")]
                    [Validation(Required=false)]
                    public string ApprovalMethod { get; set; }

                    [NameInMap("approvalType")]
                    [Validation(Required=false)]
                    public string ApprovalType { get; set; }

                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workflowForecastNodes")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowForecastNodes> WorkflowForecastNodes { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowForecastNodes : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

            }

        }

    }

}
