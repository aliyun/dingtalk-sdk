// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetCustomerInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCustomerInfoResponseBodyResult Result { get; set; }
        public class GetCustomerInfoResponseBodyResult : TeaModel {
            [NameInMap("createAt")]
            [Validation(Required=false)]
            public string CreateAt { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            [NameInMap("teamCode")]
            [Validation(Required=false)]
            public string TeamCode { get; set; }

        }

    }

}
