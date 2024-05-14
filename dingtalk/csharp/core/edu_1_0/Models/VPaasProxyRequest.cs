// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class VPaasProxyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actionCode")]
        [Validation(Required=false)]
        public string ActionCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("publicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

    }

}
