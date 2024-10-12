// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class GetTbUserIdByDingUserIdResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetTbUserIdByDingUserIdResponseBodyResult> Result { get; set; }
        public class GetTbUserIdByDingUserIdResponseBodyResult : TeaModel {
            [NameInMap("dingtalkUserId")]
            [Validation(Required=false)]
            public string DingtalkUserId { get; set; }

            [NameInMap("tbUserId")]
            [Validation(Required=false)]
            public string TbUserId { get; set; }

        }

    }

}
