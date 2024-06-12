// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_2_0.Models
{
    public class GetRecordResponseBody : TeaModel {
        [NameInMap("fields")]
        [Validation(Required=false)]
        public Dictionary<string, object> Fields { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

    }

}
