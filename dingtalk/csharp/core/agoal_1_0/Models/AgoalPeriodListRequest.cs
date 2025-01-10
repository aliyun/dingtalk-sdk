// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalPeriodListRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public AgoalPeriodListRequestBody Body { get; set; }
        public class AgoalPeriodListRequestBody : TeaModel {
            [NameInMap("periodTypes")]
            [Validation(Required=false)]
            public List<string> PeriodTypes { get; set; }

        }

    }

}
