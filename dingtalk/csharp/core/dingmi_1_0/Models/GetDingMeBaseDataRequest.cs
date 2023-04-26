// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetDingMeBaseDataRequest : TeaModel {
        [NameInMap("appKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("byDay")]
        [Validation(Required=false)]
        public bool? ByDay { get; set; }

        [NameInMap("endDay")]
        [Validation(Required=false)]
        public string EndDay { get; set; }

        [NameInMap("startDay")]
        [Validation(Required=false)]
        public string StartDay { get; set; }

    }

}
