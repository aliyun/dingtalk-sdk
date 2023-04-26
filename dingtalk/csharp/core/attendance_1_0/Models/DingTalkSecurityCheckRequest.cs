// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class DingTalkSecurityCheckRequest : TeaModel {
        [NameInMap("clientVer")]
        [Validation(Required=false)]
        public string ClientVer { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        [NameInMap("platformVer")]
        [Validation(Required=false)]
        public string PlatformVer { get; set; }

        [NameInMap("sec")]
        [Validation(Required=false)]
        public string Sec { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
