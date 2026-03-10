// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class ConvertUnionIdRequest : TeaModel {
        [NameInMap("unionIdList")]
        [Validation(Required=false)]
        public List<string> UnionIdList { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
