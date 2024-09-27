// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignSyncEventRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openEsign</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingd0c871e2dfc941a34ac5d6980864d335</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;: &quot;名字&quot;}</para>
        /// </summary>
        [NameInMap("esignData")]
        [Validation(Required=false)]
        public string EsignData { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PbnhW6rVXRg8u6T4NiiOwwQiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
