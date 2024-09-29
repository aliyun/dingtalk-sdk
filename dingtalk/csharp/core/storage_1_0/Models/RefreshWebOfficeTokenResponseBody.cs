// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class RefreshWebOfficeTokenResponseBody : TeaModel {
        [NameInMap("webOfficeAccessToken")]
        [Validation(Required=false)]
        public string WebOfficeAccessToken { get; set; }

        [NameInMap("webOfficeRefreshToken")]
        [Validation(Required=false)]
        public string WebOfficeRefreshToken { get; set; }

    }

}
