// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class SheetFindAllResponseBody : TeaModel {
        [NameInMap("value")]
        [Validation(Required=false)]
        public List<SheetFindAllResponseBodyValue> Value { get; set; }
        public class SheetFindAllResponseBodyValue : TeaModel {
            [NameInMap("a1Notation")]
            [Validation(Required=false)]
            public string A1Notation { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<List<object>> Values { get; set; }

        }

    }

}
