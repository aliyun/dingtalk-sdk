// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduGetFileSpaceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EduGetFileSpaceResponseBodyResult Result { get; set; }
        public class EduGetFileSpaceResponseBodyResult : TeaModel {
            [NameInMap("folderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
