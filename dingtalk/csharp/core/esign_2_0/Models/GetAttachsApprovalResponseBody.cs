// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0.Models
{
    public class GetAttachsApprovalResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAttachsApprovalResponseBodyData> Data { get; set; }
        public class GetAttachsApprovalResponseBodyData : TeaModel {
            [NameInMap("files")]
            [Validation(Required=false)]
            public List<GetAttachsApprovalResponseBodyDataFiles> Files { get; set; }
            public class GetAttachsApprovalResponseBodyDataFiles : TeaModel {
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("originalFileUrl")]
                [Validation(Required=false)]
                public string OriginalFileUrl { get; set; }

                [NameInMap("signFinishFileUrl")]
                [Validation(Required=false)]
                public string SignFinishFileUrl { get; set; }

            }

            [NameInMap("flowId")]
            [Validation(Required=false)]
            public string FlowId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
