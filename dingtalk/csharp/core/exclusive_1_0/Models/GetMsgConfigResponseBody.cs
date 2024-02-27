// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetMsgConfigResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMsgConfigResponseBodyData Data { get; set; }
        public class GetMsgConfigResponseBodyData : TeaModel {
            [NameInMap("groupAttributes")]
            [Validation(Required=false)]
            public List<GetMsgConfigResponseBodyDataGroupAttributes> GroupAttributes { get; set; }
            public class GetMsgConfigResponseBodyDataGroupAttributes : TeaModel {
                [NameInMap("configGroupId")]
                [Validation(Required=false)]
                public long? ConfigGroupId { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("groupTopic")]
                [Validation(Required=false)]
                public string GroupTopic { get; set; }

                [NameInMap("groupType")]
                [Validation(Required=false)]
                public string GroupType { get; set; }

                [NameInMap("listDynamicAttr")]
                [Validation(Required=false)]
                public List<GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr> ListDynamicAttr { get; set; }
                public class GetMsgConfigResponseBodyDataGroupAttributesListDynamicAttr : TeaModel {
                    [NameInMap("attrCode")]
                    [Validation(Required=false)]
                    public string AttrCode { get; set; }

                    [NameInMap("listAttrOptionsCode")]
                    [Validation(Required=false)]
                    public List<string> ListAttrOptionsCode { get; set; }

                }

                [NameInMap("listReceiver")]
                [Validation(Required=false)]
                public List<GetMsgConfigResponseBodyDataGroupAttributesListReceiver> ListReceiver { get; set; }
                public class GetMsgConfigResponseBodyDataGroupAttributesListReceiver : TeaModel {
                    [NameInMap("employeeCode")]
                    [Validation(Required=false)]
                    public string EmployeeCode { get; set; }

                    [NameInMap("employeeName")]
                    [Validation(Required=false)]
                    public string EmployeeName { get; set; }

                }

                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("ownerJobNo")]
                [Validation(Required=false)]
                public string OwnerJobNo { get; set; }

                [NameInMap("subRuleCode")]
                [Validation(Required=false)]
                public string SubRuleCode { get; set; }

            }

            [NameInMap("msgConfigs")]
            [Validation(Required=false)]
            public GetMsgConfigResponseBodyDataMsgConfigs MsgConfigs { get; set; }
            public class GetMsgConfigResponseBodyDataMsgConfigs : TeaModel {
                [NameInMap("cardId")]
                [Validation(Required=false)]
                public string CardId { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("customParameters")]
                [Validation(Required=false)]
                public string CustomParameters { get; set; }

                [NameInMap("msgContentConsisFlag")]
                [Validation(Required=false)]
                public int? MsgContentConsisFlag { get; set; }

                [NameInMap("msgId")]
                [Validation(Required=false)]
                public string MsgId { get; set; }

                [NameInMap("robotCode")]
                [Validation(Required=false)]
                public string RobotCode { get; set; }

                [NameInMap("ruleBusinessCode")]
                [Validation(Required=false)]
                public string RuleBusinessCode { get; set; }

                [NameInMap("ruleCategory")]
                [Validation(Required=false)]
                public int? RuleCategory { get; set; }

                [NameInMap("ruleCode")]
                [Validation(Required=false)]
                public string RuleCode { get; set; }

                [NameInMap("ruleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("subRuleCode")]
                [Validation(Required=false)]
                public string SubRuleCode { get; set; }

                [NameInMap("systemCode")]
                [Validation(Required=false)]
                public string SystemCode { get; set; }

                [NameInMap("taskBatchNo")]
                [Validation(Required=false)]
                public string TaskBatchNo { get; set; }

            }

            [NameInMap("receiverAttributes")]
            [Validation(Required=false)]
            public List<GetMsgConfigResponseBodyDataReceiverAttributes> ReceiverAttributes { get; set; }
            public class GetMsgConfigResponseBodyDataReceiverAttributes : TeaModel {
                [NameInMap("employeeCode")]
                [Validation(Required=false)]
                public string EmployeeCode { get; set; }

            }

            [NameInMap("unitAttributes")]
            [Validation(Required=false)]
            public List<GetMsgConfigResponseBodyDataUnitAttributes> UnitAttributes { get; set; }
            public class GetMsgConfigResponseBodyDataUnitAttributes : TeaModel {
                [NameInMap("unitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

            }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
