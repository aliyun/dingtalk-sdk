// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ShareUrlResponseBody : TeaModel {
        [NameInMap("shareUrlInfo")]
        [Validation(Required=false)]
        public ShareUrlResponseBodyShareUrlInfo ShareUrlInfo { get; set; }
        public class ShareUrlResponseBodyShareUrlInfo : TeaModel {
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

    }

}
