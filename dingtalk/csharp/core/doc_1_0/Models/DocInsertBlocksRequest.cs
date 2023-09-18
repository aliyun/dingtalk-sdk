// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocInsertBlocksRequest : TeaModel {
        [NameInMap("blockId")]
        [Validation(Required=false)]
        public string BlockId { get; set; }

        [NameInMap("element")]
        [Validation(Required=false)]
        public Dictionary<string, object> Element { get; set; }

        [NameInMap("index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("where")]
        [Validation(Required=false)]
        public string Where { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
