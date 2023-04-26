// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetRowsVisibilityRequest : TeaModel {
        [NameInMap("row")]
        [Validation(Required=false)]
        public long? Row { get; set; }

        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
