// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class PrepareImportUploadResponseBody : TeaModel {
        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public long? ExpireAt { get; set; }

        [NameInMap("importId")]
        [Validation(Required=false)]
        public string ImportId { get; set; }

        [NameInMap("uploadUrl")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
