// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetPreviewInfoRequest : TeaModel {
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        [NameInMap("watermark")]
        [Validation(Required=false)]
        public bool? Watermark { get; set; }

    }

}
