// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("client_id")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("client_secret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("grant_type")]
        [Validation(Required=false)]
        public string GrantType { get; set; }

    }

}
