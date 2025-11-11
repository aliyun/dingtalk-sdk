// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class HhoCallBackRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("dtNotificationId")]
        [Validation(Required=false)]
        public string DtNotificationId { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

    }

}
