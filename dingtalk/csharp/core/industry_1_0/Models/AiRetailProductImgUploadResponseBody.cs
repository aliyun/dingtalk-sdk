// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class AiRetailProductImgUploadResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AiRetailProductImgUploadResponseBodyResult Result { get; set; }
        public class AiRetailProductImgUploadResponseBodyResult : TeaModel {
            [NameInMap("ossFileId")]
            [Validation(Required=false)]
            public string OssFileId { get; set; }

            [NameInMap("ossUploadUrl")]
            [Validation(Required=false)]
            public string OssUploadUrl { get; set; }

        }

    }

}
