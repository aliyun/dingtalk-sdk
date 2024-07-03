// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class OpenGroupUserRoleQueryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public OpenGroupUserRoleQueryResponseBodyResult Result { get; set; }
        public class OpenGroupUserRoleQueryResponseBodyResult : TeaModel {
            [NameInMap("groupRoles")]
            [Validation(Required=false)]
            public List<OpenGroupUserRoleQueryResponseBodyResultGroupRoles> GroupRoles { get; set; }
            public class OpenGroupUserRoleQueryResponseBodyResultGroupRoles : TeaModel {
                [NameInMap("openRoleId")]
                [Validation(Required=false)]
                public string OpenRoleId { get; set; }

                [NameInMap("roleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
