// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class InsertRecordsResponseBody : TeaModel {
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<InsertRecordsResponseBodyValue> Value { get; set; }
        public class InsertRecordsResponseBodyValue : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
