// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetProcessDesignByCodeResponseBody : TeaModel {
        [NameInMap("approvalSummary")]
        [Validation(Required=false)]
        public List<GetProcessDesignByCodeResponseBodyApprovalSummary> ApprovalSummary { get; set; }
        public class GetProcessDesignByCodeResponseBodyApprovalSummary : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public GetProcessDesignByCodeResponseBodyApprovalSummaryTitle Title { get; set; }
            public class GetProcessDesignByCodeResponseBodyApprovalSummaryTitle : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>i18n</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

        }

        [NameInMap("flowConfig")]
        [Validation(Required=false)]
        public GetProcessDesignByCodeResponseBodyFlowConfig FlowConfig { get; set; }
        public class GetProcessDesignByCodeResponseBodyFlowConfig : TeaModel {
            [NameInMap("sid_instDetail")]
            [Validation(Required=false)]
            public List<GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail> SidInstDetail { get; set; }
            public class GetProcessDesignByCodeResponseBodyFlowConfigSidInstDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>HIDDEN</para>
                /// </summary>
                [NameInMap("fieldBehavior")]
                [Validation(Required=false)]
                public string FieldBehavior { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>textField_xxx</para>
                /// </summary>
                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

        }

        [NameInMap("formulaRules")]
        [Validation(Required=false)]
        public List<GetProcessDesignByCodeResponseBodyFormulaRules> FormulaRules { get; set; }
        public class GetProcessDesignByCodeResponseBodyFormulaRules : TeaModel {
            [NameInMap("activityAction")]
            [Validation(Required=false)]
            public List<string> ActivityAction { get; set; }

            [NameInMap("activityId")]
            [Validation(Required=false)]
            public List<string> ActivityId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>n</para>
            /// </summary>
            [NameInMap("block")]
            [Validation(Required=false)]
            public string Block { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetProcessDesignByCodeResponseBodyFormulaRulesName Name { get; set; }
            public class GetProcessDesignByCodeResponseBodyFormulaRulesName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>START</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("rule")]
            [Validation(Required=false)]
            public GetProcessDesignByCodeResponseBodyFormulaRulesRule Rule { get; set; }
            public class GetProcessDesignByCodeResponseBodyFormulaRulesRule : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>EQ(#{textField_xxx},1)</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EQ(单行文本,1)</para>
                /// </summary>
                [NameInMap("displayRule")]
                [Validation(Required=false)]
                public string DisplayRule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EQ(#{textField_xxx},1)</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VALIDATOR</para>
            /// </summary>
            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<GetProcessDesignByCodeResponseBodyNodes> Nodes { get; set; }
        public class GetProcessDesignByCodeResponseBodyNodes : TeaModel {
            [NameInMap("childNodes")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ChildNodes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>请选择审批人</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetProcessDesignByCodeResponseBodyNodesName Name { get; set; }
            public class GetProcessDesignByCodeResponseBodyNodesName : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>zhangsan</para>
                /// </summary>
                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            [NameInMap("nextId")]
            [Validation(Required=false)]
            public List<string> NextId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_xxx</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node_xxx</para>
            /// </summary>
            [NameInMap("prevId")]
            [Validation(Required=false)]
            public string PrevId { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public Dictionary<string, object> Props { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>approval</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("props")]
        [Validation(Required=false)]
        public GetProcessDesignByCodeResponseBodyProps Props { get; set; }
        public class GetProcessDesignByCodeResponseBodyProps : TeaModel {
            [NameInMap("allowCollaboration")]
            [Validation(Required=false)]
            public bool? AllowCollaboration { get; set; }

            [NameInMap("allowTemporaryStorage")]
            [Validation(Required=false)]
            public bool? AllowTemporaryStorage { get; set; }

            [NameInMap("allowWithdraw")]
            [Validation(Required=false)]
            public bool? AllowWithdraw { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FORM-xxx</para>
            /// </summary>
            [NameInMap("bindingForm")]
            [Validation(Required=false)]
            public string BindingForm { get; set; }

            [NameInMap("noRecordRecall")]
            [Validation(Required=false)]
            public bool? NoRecordRecall { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TPROC--BDC66HB1FIPNPCMNE5VV787RY4D5327NBKTZL0</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("processDetailUrl")]
            [Validation(Required=false)]
            public string ProcessDetailUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("processInitUrl")]
            [Validation(Required=false)]
            public string ProcessInitUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("processMobileDetailUrl")]
            [Validation(Required=false)]
            public string ProcessMobileDetailUrl { get; set; }

            [NameInMap("stopAssociationRulesIfFailed")]
            [Validation(Required=false)]
            public bool? StopAssociationRulesIfFailed { get; set; }

        }

    }

}
