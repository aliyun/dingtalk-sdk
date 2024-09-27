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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isForecastSuccess")]
            [Validation(Required=false)]
            public bool? IsForecastSuccess { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isStaticWorkflow")]
            [Validation(Required=false)]
            public bool? IsStaticWorkflow { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROC-2B60E506-D6CB-43F3-B661-359B27F90947</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>63657309999</para>
            /// </summary>
            [NameInMap("processId")]
            [Validation(Required=false)]
            public long? ProcessId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2665246100805992</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workflowActivityRules")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowActivityRules> WorkflowActivityRules { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowActivityRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1918_5cd3</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>审批人</para>
                /// </summary>
                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>包括 target_select、target_approval 等</para>
                /// </summary>
                [NameInMap("activityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isTargetSelect")]
                [Validation(Required=false)]
                public bool? IsTargetSelect { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1918_5cd3</para>
                /// </summary>
                [NameInMap("prevActivityId")]
                [Validation(Required=false)]
                public string PrevActivityId { get; set; }

                [NameInMap("workflowActor")]
                [Validation(Required=false)]
                public ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor WorkflowActor { get; set; }
                public class ProcessForecastResponseBodyResultWorkflowActivityRulesWorkflowActor : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ALL:并行，ONE_BY_ONE:串行</para>
                    /// </summary>
                    [NameInMap("actorActivateType")]
                    [Validation(Required=false)]
                    public string ActorActivateType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>manual_e203_14a3_895a_45ad</para>
                    /// </summary>
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

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>allStaff：全公司，approvals：指定成员，labels：角色</para>
                    /// </summary>
                    [NameInMap("actorSelectionType")]
                    [Validation(Required=false)]
                    public string ActorSelectionType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>approver:审批人，notifier:抄送人，audit：办理人</para>
                    /// </summary>
                    [NameInMap("actorType")]
                    [Validation(Required=false)]
                    public string ActorType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("allowedMulti")]
                    [Validation(Required=false)]
                    public bool? AllowedMulti { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ONE_BY_ONE：依次审批，AND：会签审批，OR：或签审批</para>
                    /// </summary>
                    [NameInMap("approvalMethod")]
                    [Validation(Required=false)]
                    public string ApprovalMethod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MANUAL:人工审批，AUTO_AGREE:自动通过，AUTO_REFUSE:自动拒绝</para>
                    /// </summary>
                    [NameInMap("approvalType")]
                    [Validation(Required=false)]
                    public string ApprovalType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("workflowForecastNodes")]
            [Validation(Required=false)]
            public List<ProcessForecastResponseBodyResultWorkflowForecastNodes> WorkflowForecastNodes { get; set; }
            public class ProcessForecastResponseBodyResultWorkflowForecastNodes : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1cc3_959a</para>
                /// </summary>
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public string ActivityId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>line-random-1cc3_959a-831a_607b</para>
                /// </summary>
                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

            }

        }

    }

}
