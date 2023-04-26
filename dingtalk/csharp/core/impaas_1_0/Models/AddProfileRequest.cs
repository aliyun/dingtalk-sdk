// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkimpaas_1_0.Models
{
    public class AddProfileRequest : TeaModel {
        [NameInMap("appUid")]
        [Validation(Required=false)]
        public string AppUid { get; set; }

        [NameInMap("avatarMediaId")]
        [Validation(Required=false)]
        public string AvatarMediaId { get; set; }

        [NameInMap("mobileNumber")]
        [Validation(Required=false)]
        public string MobileNumber { get; set; }

        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

    }

}
