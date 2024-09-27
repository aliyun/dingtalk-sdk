// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupCapacityOrderPlaceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>85000</para>
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
        /// <para>1652669110553</para>
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
        public Dictionary<string, string> ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("markedPrice")]
        [Validation(Required=false)]
        public long? MarkedPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ciddfasvc</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>033333</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12389023745345500</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1652669110553</para>
        /// </summary>
        [NameInMap("targetEffectUntil")]
        [Validation(Required=false)]
        public long? TargetEffectUntil { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90ji34ontgrefv98u0ijo3q4awefg90rej</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
