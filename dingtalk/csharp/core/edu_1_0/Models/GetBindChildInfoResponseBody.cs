// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetBindChildInfoResponseBody : TeaModel {
        [NameInMap("childUserId")]
        [Validation(Required=false)]
        public string ChildUserId { get; set; }

        [NameInMap("currentUserId")]
        [Validation(Required=false)]
        public string CurrentUserId { get; set; }

        [NameInMap("familyCorpId")]
        [Validation(Required=false)]
        public string FamilyCorpId { get; set; }

    }

}
