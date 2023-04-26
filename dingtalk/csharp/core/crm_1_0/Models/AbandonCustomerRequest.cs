// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AbandonCustomerRequest : TeaModel {
        [NameInMap("customTrackDesc")]
        [Validation(Required=false)]
        public string CustomTrackDesc { get; set; }

        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

        [NameInMap("operatorUserId")]
        [Validation(Required=false)]
        public string OperatorUserId { get; set; }

        [NameInMap("optType")]
        [Validation(Required=false)]
        public string OptType { get; set; }

    }

}
