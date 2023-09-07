// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class AddPluginRuleRequest : TeaModel {
        [NameInMap("chatType")]
        [Validation(Required=false)]
        public string ChatType { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<AddPluginRuleRequestRules> Rules { get; set; }
        public class AddPluginRuleRequestRules : TeaModel {
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
