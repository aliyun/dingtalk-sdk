// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetAttachmentSpaceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAttachmentSpaceResponseBodyResult Result { get; set; }
        public class GetAttachmentSpaceResponseBodyResult : TeaModel {
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public long? SpaceId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
