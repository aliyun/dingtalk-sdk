// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesDispatchTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public IndustryManufactureMesDispatchTaskResponseBodyResult Result { get; set; }
        public class IndustryManufactureMesDispatchTaskResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
