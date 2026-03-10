// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkflashmeeting_1_0.Models
{
    public class GetShanhuiAttachmentsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetShanhuiAttachmentsResponseBodyResult Result { get; set; }
        public class GetShanhuiAttachmentsResponseBodyResult : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<GetShanhuiAttachmentsResponseBodyResultAttachments> Attachments { get; set; }
            public class GetShanhuiAttachmentsResponseBodyResultAttachments : TeaModel {
                [NameInMap("resourceUrl")]
                [Validation(Required=false)]
                public string ResourceUrl { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
