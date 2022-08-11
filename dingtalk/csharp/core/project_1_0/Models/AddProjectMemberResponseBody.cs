// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class AddProjectMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<AddProjectMemberResponseBodyResult> Result { get; set; }
        public class AddProjectMemberResponseBodyResult : TeaModel {
            [NameInMap("joined")]
            [Validation(Required=false)]
            public string Joined { get; set; }

            [NameInMap("nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

        }

    }

}
