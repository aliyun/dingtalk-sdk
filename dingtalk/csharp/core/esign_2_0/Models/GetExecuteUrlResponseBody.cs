// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetExecuteUrlResponseBody : TeaModel {
        [NameInMap("longUrl")]
        [Validation(Required=false)]
        public string LongUrl { get; set; }

        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        [NameInMap("shortUrl")]
        [Validation(Required=false)]
        public string ShortUrl { get; set; }

    }

}
