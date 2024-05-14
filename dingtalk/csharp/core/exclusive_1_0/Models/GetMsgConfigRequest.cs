// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetMsgConfigRequest : TeaModel {
        [NameInMap("groupTopic")]
        [Validation(Required=false)]
        public string GroupTopic { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("listDynamicAttr")]
        [Validation(Required=false)]
        public List<GetMsgConfigRequestListDynamicAttr> ListDynamicAttr { get; set; }
        public class GetMsgConfigRequestListDynamicAttr : TeaModel {
            [NameInMap("attrCode")]
            [Validation(Required=false)]
            public string AttrCode { get; set; }

            [NameInMap("listAttrOptionsCode")]
            [Validation(Required=false)]
            public List<string> ListAttrOptionsCode { get; set; }

        }

        [NameInMap("listEmployeeCode")]
        [Validation(Required=false)]
        public List<string> ListEmployeeCode { get; set; }

        [NameInMap("listUnitId")]
        [Validation(Required=false)]
        public List<long?> ListUnitId { get; set; }

        [NameInMap("ownerJobNo")]
        [Validation(Required=false)]
        public string OwnerJobNo { get; set; }

        [NameInMap("ruleBusinessCode")]
        [Validation(Required=false)]
        public string RuleBusinessCode { get; set; }

        [NameInMap("ruleCategory")]
        [Validation(Required=false)]
        public int? RuleCategory { get; set; }

        [NameInMap("ruleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("sysCode")]
        [Validation(Required=false)]
        public string SysCode { get; set; }

    }

}
