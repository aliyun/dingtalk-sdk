// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ListProcessInstanceIdsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListProcessInstanceIdsResponseBodyResult Result { get; set; }
        public class ListProcessInstanceIdsResponseBodyResult : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<string> List { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
