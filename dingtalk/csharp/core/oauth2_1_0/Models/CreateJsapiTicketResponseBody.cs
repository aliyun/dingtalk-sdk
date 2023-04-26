// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class CreateJsapiTicketResponseBody : TeaModel {
        [NameInMap("expireIn")]
        [Validation(Required=false)]
        public long? ExpireIn { get; set; }

        [NameInMap("jsapiTicket")]
        [Validation(Required=false)]
        public string JsapiTicket { get; set; }

    }

}
