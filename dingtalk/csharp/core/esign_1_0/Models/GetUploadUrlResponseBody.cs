// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetUploadUrlResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUploadUrlResponseBodyData Data { get; set; }
        public class GetUploadUrlResponseBodyData : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }
            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
