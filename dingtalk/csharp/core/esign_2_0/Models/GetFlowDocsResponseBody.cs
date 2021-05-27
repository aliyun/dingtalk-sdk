// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetFlowDocsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetFlowDocsResponseBodyData> Data { get; set; }
        public class GetFlowDocsResponseBodyData : TeaModel {
            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileUrl")]
            [Validation(Required=false)]
            public string FileUrl { get; set; }

        }

    }

}
