// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateAclsRequest : TeaModel {
        [NameInMap("privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

        [NameInMap("scope")]
        [Validation(Required=false)]
        public CreateAclsRequestScope Scope { get; set; }
        public class CreateAclsRequestScope : TeaModel {
            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("sendMsg")]
        [Validation(Required=false)]
        public bool? SendMsg { get; set; }

    }

}
