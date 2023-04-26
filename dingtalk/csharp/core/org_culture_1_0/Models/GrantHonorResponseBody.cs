// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class GrantHonorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GrantHonorResponseBodyResult Result { get; set; }
        public class GrantHonorResponseBodyResult : TeaModel {
            [NameInMap("failedUserIds")]
            [Validation(Required=false)]
            public List<string> FailedUserIds { get; set; }

            [NameInMap("successUserIds")]
            [Validation(Required=false)]
            public List<string> SuccessUserIds { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
