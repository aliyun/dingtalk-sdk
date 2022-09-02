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
            /// <summary>
            /// 失败的userId
            /// </summary>
            [NameInMap("failedUserIds")]
            [Validation(Required=false)]
            public List<string> FailedUserIds { get; set; }

            /// <summary>
            /// 成功的userId
            /// </summary>
            [NameInMap("successUserIds")]
            [Validation(Required=false)]
            public List<string> SuccessUserIds { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
