// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class GetDataDeliverRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DELIVER-3e1a2d2f-fa76-45e8-XXXX-7fd29307c859</para>
        /// </summary>
        [NameInMap("deliverId")]
        [Validation(Required=false)]
        public string DeliverId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RT</para>
        /// </summary>
        [NameInMap("dispatchingItemType")]
        [Validation(Required=false)]
        public string DispatchingItemType { get; set; }

    }

}
