// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetConditionFormComponentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetConditionFormComponentResponseBodyResult> Result { get; set; }
        public class GetConditionFormComponentResponseBodyResult : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

        }

    }

}
