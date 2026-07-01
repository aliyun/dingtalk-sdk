// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class CreateTeamResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateTeamResponseBodyResult Result { get; set; }
        public class CreateTeamResponseBodyResult : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("teamCode")]
            [Validation(Required=false)]
            public string TeamCode { get; set; }

        }

    }

}
