// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class BusinessMatchRequest : TeaModel {
        [NameInMap("businessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
