// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class ListClueTagResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListClueTagResponseBodyResult> Result { get; set; }
        public class ListClueTagResponseBodyResult : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("tagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
