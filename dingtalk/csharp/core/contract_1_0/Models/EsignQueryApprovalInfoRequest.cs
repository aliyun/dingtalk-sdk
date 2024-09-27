// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryApprovalInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingd0c871e2dfc941a34ac5d6980864d335</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5556ae0359c64c4b9491c0c3c339341f</para>
        /// </summary>
        [NameInMap("esignFlowId")]
        [Validation(Required=false)]
        public string EsignFlowId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PbnhW6rVXRg8u6T4NiiOwwQiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
