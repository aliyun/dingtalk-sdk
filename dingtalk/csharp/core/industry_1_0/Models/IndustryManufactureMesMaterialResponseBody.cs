// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class IndustryManufactureMesMaterialResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public IndustryManufactureMesMaterialResponseBodyResult Result { get; set; }
        public class IndustryManufactureMesMaterialResponseBodyResult : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }
        };

    }

}
