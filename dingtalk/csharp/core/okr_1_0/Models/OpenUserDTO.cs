// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenUserDTO : TeaModel {
        [NameInMap("dingUserId")]
        [Validation(Required=false)]
        public string DingUserId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("userUid")]
        [Validation(Required=false)]
        public string UserUid { get; set; }

        [NameInMap("workNo")]
        [Validation(Required=false)]
        public string WorkNo { get; set; }

    }

}
