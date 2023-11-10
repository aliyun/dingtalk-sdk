// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class DelOrgAccUserOwnnessRequest : TeaModel {
        [NameInMap("ownenssType")]
        [Validation(Required=false)]
        public long? OwnenssType { get; set; }

        [NameInMap("ownnessId")]
        [Validation(Required=false)]
        public long? OwnnessId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
