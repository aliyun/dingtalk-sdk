// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ValidateUserRoleResponseBody : TeaModel {
        [NameInMap("matchParentIdentity")]
        [Validation(Required=false)]
        public bool? MatchParentIdentity { get; set; }

        [NameInMap("matchTeacherIdentity")]
        [Validation(Required=false)]
        public bool? MatchTeacherIdentity { get; set; }

    }

}
