// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class GetMediaUrlRequest : TeaModel {
        [NameInMap("mediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("urlExpireTime")]
        [Validation(Required=false)]
        public int? UrlExpireTime { get; set; }

    }

}
