// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetDingMeBaseDataResponseBody : TeaModel {
        [NameInMap("fromCache")]
        [Validation(Required=false)]
        public bool? FromCache { get; set; }

        [NameInMap("rawset")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Rawset { get; set; }

        [NameInMap("runtime")]
        [Validation(Required=false)]
        public long? Runtime { get; set; }

        [NameInMap("tips")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tips { get; set; }

    }

}
