// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class TripPlatformUnifiedEntryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;projects&quot;:[{&quot;thirdId&quot;:&quot;00001&quot;,&quot;number&quot;:&quot;00001&quot;,&quot;scope&quot;:1,&quot;action&quot;:0,&quot;name&quot;:&quot;总务01项目&quot;}]}</para>
        /// </summary>
        [NameInMap("messages")]
        [Validation(Required=false)]
        public string Messages { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>partner_syncProject</para>
        /// </summary>
        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

    }

}
