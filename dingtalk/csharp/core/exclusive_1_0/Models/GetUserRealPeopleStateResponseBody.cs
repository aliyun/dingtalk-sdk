// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetUserRealPeopleStateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetUserRealPeopleStateResponseBodyData> Data { get; set; }
        public class GetUserRealPeopleStateResponseBodyData : TeaModel {
            [NameInMap("state")]
            [Validation(Required=false)]
            public int? State { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
