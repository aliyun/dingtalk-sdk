// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateAclsResponseBody : TeaModel {
        [NameInMap("aclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public CreateAclsResponseBodyScope Scope { get; set; }
        public class CreateAclsResponseBodyScope : TeaModel {
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
