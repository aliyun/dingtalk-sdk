// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CallbackRegiesterRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("apiSecret")]
        [Validation(Required=false)]
        public string ApiSecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("callbackKey")]
        [Validation(Required=false)]
        public string CallbackKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
