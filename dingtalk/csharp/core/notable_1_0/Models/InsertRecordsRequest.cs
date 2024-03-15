// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class InsertRecordsRequest : TeaModel {
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<InsertRecordsRequestRecords> Records { get; set; }
        public class InsertRecordsRequestRecords : TeaModel {
            [NameInMap("fields")]
            [Validation(Required=false)]
            public Dictionary<string, object> Fields { get; set; }

        }

    }

}
