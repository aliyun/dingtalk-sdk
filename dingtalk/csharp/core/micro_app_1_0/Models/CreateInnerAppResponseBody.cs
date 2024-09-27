// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class CreateInnerAppResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("appSecret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
