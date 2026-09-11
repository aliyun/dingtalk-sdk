// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class BatchUpdateDeviceCutCustomerSwitchShrinkRequest : TeaModel {
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("snList")]
        [Validation(Required=false)]
        public string SnListShrink { get; set; }

    }

}
