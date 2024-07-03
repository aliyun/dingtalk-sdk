// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class CloseDataDeliverRequest : TeaModel {
        [NameInMap("deliverId")]
        [Validation(Required=false)]
        public string DeliverId { get; set; }

        [NameInMap("dispatchingItemType")]
        [Validation(Required=false)]
        public string DispatchingItemType { get; set; }

    }

}
