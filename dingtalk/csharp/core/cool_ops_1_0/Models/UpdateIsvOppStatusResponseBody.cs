// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcool_ops_1_0.Models
{
    public class UpdateIsvOppStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateIsvOppStatusResponseBodyResult Result { get; set; }
        public class UpdateIsvOppStatusResponseBodyResult : TeaModel {
            [NameInMap("value")]
            [Validation(Required=false)]
            public bool? Value { get; set; }

        }

    }

}
