// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreUsersResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<DigitalStoreUsersResponseBodyContent> Content { get; set; }
        public class DigitalStoreUsersResponseBodyContent : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
