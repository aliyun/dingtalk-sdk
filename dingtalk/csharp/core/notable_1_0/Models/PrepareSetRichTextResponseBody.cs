// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class PrepareSetRichTextResponseBody : TeaModel {
        [NameInMap("markdown")]
        [Validation(Required=false)]
        public string Markdown { get; set; }

        [NameInMap("uploadInfos")]
        [Validation(Required=false)]
        public List<PrepareSetRichTextResponseBodyUploadInfos> UploadInfos { get; set; }
        public class PrepareSetRichTextResponseBodyUploadInfos : TeaModel {
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

            [NameInMap("uploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

    }

}
