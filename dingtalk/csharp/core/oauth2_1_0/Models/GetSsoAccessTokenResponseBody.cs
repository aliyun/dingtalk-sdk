// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetSsoAccessTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("expireIn")]
        [Validation(Required=false)]
        public long? ExpireIn { get; set; }

    }

}
