// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TransformToExclusiveAccountRequest : TeaModel {
        [NameInMap("idpDingTalk")]
        [Validation(Required=false)]
        public bool? IdpDingTalk { get; set; }

        [NameInMap("initPassword")]
        [Validation(Required=false)]
        public string InitPassword { get; set; }

        [NameInMap("loginId")]
        [Validation(Required=false)]
        public string LoginId { get; set; }

        [NameInMap("transformType")]
        [Validation(Required=false)]
        public string TransformType { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
