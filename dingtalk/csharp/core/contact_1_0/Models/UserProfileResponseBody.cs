// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class UserProfileResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<UserProfileResponseBodyResult> Result { get; set; }
        public class UserProfileResponseBodyResult : TeaModel {
            [NameInMap("mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            [NameInMap("orgIds")]
            [Validation(Required=false)]
            public string OrgIds { get; set; }

            [NameInMap("stateCode")]
            [Validation(Required=false)]
            public string StateCode { get; set; }

        }

    }

}
