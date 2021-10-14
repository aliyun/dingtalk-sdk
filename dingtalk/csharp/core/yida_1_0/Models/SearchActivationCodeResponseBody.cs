// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class SearchActivationCodeResponseBody : TeaModel {
        /// <summary>
        /// activationCode
        /// </summary>
        [NameInMap("activationCode")]
        [Validation(Required=false)]
        public string ActivationCode { get; set; }

        /// <summary>
        /// authType
        /// </summary>
        [NameInMap("authType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        /// <summary>
        /// expireTime
        /// </summary>
        [NameInMap("expireTimeGMT")]
        [Validation(Required=false)]
        public string ExpireTimeGMT { get; set; }

        /// <summary>
        /// instanceId
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// status
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
