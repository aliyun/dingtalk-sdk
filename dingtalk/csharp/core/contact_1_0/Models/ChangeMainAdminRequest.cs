// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class ChangeMainAdminRequest : TeaModel {
        [NameInMap("effectCorpId")]
        [Validation(Required=false)]
        public string EffectCorpId { get; set; }

        [NameInMap("sourceUserId")]
        [Validation(Required=false)]
        public string SourceUserId { get; set; }

        [NameInMap("targetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
