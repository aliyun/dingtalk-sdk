// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmPtsServiceRequest : TeaModel {
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("outerId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
