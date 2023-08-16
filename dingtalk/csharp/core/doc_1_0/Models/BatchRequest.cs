// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class BatchRequest : TeaModel {
        [NameInMap("requests")]
        [Validation(Required=false)]
        public List<BatchRequestRequests> Requests { get; set; }
        public class BatchRequestRequests : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public object Body { get; set; }

            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
