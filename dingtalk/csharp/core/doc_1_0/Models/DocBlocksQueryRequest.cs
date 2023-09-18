// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DocBlocksQueryRequest : TeaModel {
        [NameInMap("blockType")]
        [Validation(Required=false)]
        public string BlockType { get; set; }

        [NameInMap("endIndex")]
        [Validation(Required=false)]
        public int? EndIndex { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("startIndex")]
        [Validation(Required=false)]
        public int? StartIndex { get; set; }

    }

}
