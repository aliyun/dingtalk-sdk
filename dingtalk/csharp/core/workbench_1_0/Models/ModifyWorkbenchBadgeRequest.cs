// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class ModifyWorkbenchBadgeRequest : TeaModel {
        [NameInMap("bizIdList")]
        [Validation(Required=false)]
        public List<string> BizIdList { get; set; }

        [NameInMap("isAdded")]
        [Validation(Required=false)]
        public bool? IsAdded { get; set; }

        [NameInMap("redDotRelationId")]
        [Validation(Required=false)]
        public string RedDotRelationId { get; set; }

        [NameInMap("redDotType")]
        [Validation(Required=false)]
        public string RedDotType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
