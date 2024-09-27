// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupCapacityOrderPlaceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("actualPrice")]
        [Validation(Required=false)]
        public long? ActualPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("currentCapacity")]
        [Validation(Required=false)]
        public int? CurrentCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651751906</para>
        /// </summary>
        [NameInMap("currentEffectUntil")]
        [Validation(Required=false)]
        public long? CurrentEffectUntil { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>85</para>
        /// </summary>
        [NameInMap("discount")]
        [Validation(Required=false)]
        public int? Discount { get; set; }

        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("markedPrice")]
        [Validation(Required=false)]
        public long? MarkedPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ciddmslidnxsd==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>531781123123</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1651751906</para>
        /// </summary>
        [NameInMap("targetEffectUntil")]
        [Validation(Required=false)]
        public long? TargetEffectUntil { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dfsafsd</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
