// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageReduceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("capacityLimit")]
        [Validation(Required=false)]
        public int? CapacityLimit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidnvcxzklxv</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

    }

}
