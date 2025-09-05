// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class OrgInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<OrgInfoResponseBodyResult> Result { get; set; }
        public class OrgInfoResponseBodyResult : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
