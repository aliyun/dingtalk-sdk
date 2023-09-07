// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SetColumnWidthRequest : TeaModel {
        [NameInMap("column")]
        [Validation(Required=false)]
        public int? Column { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
