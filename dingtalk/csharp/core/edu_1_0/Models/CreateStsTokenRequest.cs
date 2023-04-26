// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateStsTokenRequest : TeaModel {
        [NameInMap("deviceSn")]
        [Validation(Required=false)]
        public string DeviceSn { get; set; }

        [NameInMap("stsType")]
        [Validation(Required=false)]
        public string StsType { get; set; }

    }

}
