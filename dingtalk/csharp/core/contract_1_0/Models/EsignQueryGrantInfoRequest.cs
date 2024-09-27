// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignQueryGrantInfoRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dingd0c871e2dfc941a34ac5d6980864d335</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

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
