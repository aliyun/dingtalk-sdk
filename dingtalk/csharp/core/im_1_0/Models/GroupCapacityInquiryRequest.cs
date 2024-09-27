// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupCapacityInquiryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1Y</para>
        /// </summary>
        [NameInMap("effectiveDuration")]
        [Validation(Required=false)]
        public string EffectiveDuration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ciddmslasdfxcvbxcvgidnxsd==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5782431748978293</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

    }

}
