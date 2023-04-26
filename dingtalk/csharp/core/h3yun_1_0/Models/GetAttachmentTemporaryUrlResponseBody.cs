// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAttachmentTemporaryUrlResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAttachmentTemporaryUrlResponseBodyData Data { get; set; }
        public class GetAttachmentTemporaryUrlResponseBodyData : TeaModel {
            [NameInMap("attachmentUrl")]
            [Validation(Required=false)]
            public string AttachmentUrl { get; set; }

        }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
