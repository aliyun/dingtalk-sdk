// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetColumnsVisibilityRequest : TeaModel {
        [NameInMap("column")]
        [Validation(Required=false)]
        public long? Column { get; set; }

        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
