// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetProcessDesignResponseBody : TeaModel {
        [NameInMap("approvalSummary")]
        [Validation(Required=false)]
        public List<GetProcessDesignResponseBodyApprovalSummary> ApprovalSummary { get; set; }
        public class GetProcessDesignResponseBodyApprovalSummary : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public GetProcessDesignResponseBodyApprovalSummaryTitle Title { get; set; }
            public class GetProcessDesignResponseBodyApprovalSummaryTitle : TeaModel {
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

        }

        [NameInMap("flowConfig")]
        [Validation(Required=false)]
        public GetProcessDesignResponseBodyFlowConfig FlowConfig { get; set; }
        public class GetProcessDesignResponseBodyFlowConfig : TeaModel {
            [NameInMap("sid_instDetail")]
            [Validation(Required=false)]
            public List<GetProcessDesignResponseBodyFlowConfigSidInstDetail> SidInstDetail { get; set; }
            public class GetProcessDesignResponseBodyFlowConfigSidInstDetail : TeaModel {
                [NameInMap("fieldBehavior")]
                [Validation(Required=false)]
                public string FieldBehavior { get; set; }

                [NameInMap("fieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

            }

        }

        [NameInMap("formulaRules")]
        [Validation(Required=false)]
        public List<GetProcessDesignResponseBodyFormulaRules> FormulaRules { get; set; }
        public class GetProcessDesignResponseBodyFormulaRules : TeaModel {
            [NameInMap("activityAction")]
            [Validation(Required=false)]
            public List<string> ActivityAction { get; set; }

            [NameInMap("activityId")]
            [Validation(Required=false)]
            public List<string> ActivityId { get; set; }

            [NameInMap("block")]
            [Validation(Required=false)]
            public string Block { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetProcessDesignResponseBodyFormulaRulesName Name { get; set; }
            public class GetProcessDesignResponseBodyFormulaRulesName : TeaModel {
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            [NameInMap("rule")]
            [Validation(Required=false)]
            public GetProcessDesignResponseBodyFormulaRulesRule Rule { get; set; }
            public class GetProcessDesignResponseBodyFormulaRulesRule : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("displayRule")]
                [Validation(Required=false)]
                public string DisplayRule { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            [NameInMap("ruleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("triggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

        }

        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<GetProcessDesignResponseBodyNodes> Nodes { get; set; }
        public class GetProcessDesignResponseBodyNodes : TeaModel {
            [NameInMap("childNodes")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> ChildNodes { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public GetProcessDesignResponseBodyNodesName Name { get; set; }
            public class GetProcessDesignResponseBodyNodesName : TeaModel {
                [NameInMap("en_US")]
                [Validation(Required=false)]
                public string EnUS { get; set; }

                [NameInMap("zh_CN")]
                [Validation(Required=false)]
                public string ZhCN { get; set; }

            }

            [NameInMap("nextId")]
            [Validation(Required=false)]
            public List<string> NextId { get; set; }

            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            [NameInMap("prevId")]
            [Validation(Required=false)]
            public string PrevId { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public Dictionary<string, object> Props { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("props")]
        [Validation(Required=false)]
        public GetProcessDesignResponseBodyProps Props { get; set; }
        public class GetProcessDesignResponseBodyProps : TeaModel {
            [NameInMap("allowCollaboration")]
            [Validation(Required=false)]
            public bool? AllowCollaboration { get; set; }

            [NameInMap("allowTemporaryStorage")]
            [Validation(Required=false)]
            public bool? AllowTemporaryStorage { get; set; }

            [NameInMap("allowWithdraw")]
            [Validation(Required=false)]
            public bool? AllowWithdraw { get; set; }

            [NameInMap("bindingForm")]
            [Validation(Required=false)]
            public string BindingForm { get; set; }

            [NameInMap("noRecordRecall")]
            [Validation(Required=false)]
            public bool? NoRecordRecall { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("processDetailUrl")]
            [Validation(Required=false)]
            public string ProcessDetailUrl { get; set; }

            [NameInMap("processInitUrl")]
            [Validation(Required=false)]
            public string ProcessInitUrl { get; set; }

            [NameInMap("processMobileDetailUrl")]
            [Validation(Required=false)]
            public string ProcessMobileDetailUrl { get; set; }

            [NameInMap("stopAssociationRulesIfFailed")]
            [Validation(Required=false)]
            public bool? StopAssociationRulesIfFailed { get; set; }

        }

    }

}
