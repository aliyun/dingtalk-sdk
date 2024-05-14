// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmsg_1_0.Models
{
    public class AddPluginRuleRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("chatType")]
        [Validation(Required=false)]
        public string ChatType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rules")]
        [Validation(Required=false)]
        public List<AddPluginRuleRequestRules> Rules { get; set; }
        public class AddPluginRuleRequestRules : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("itemName")]
            [Validation(Required=false)]
            public string ItemName { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
