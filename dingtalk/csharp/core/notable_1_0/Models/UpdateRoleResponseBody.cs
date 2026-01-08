// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class UpdateRoleResponseBody : TeaModel {
        [NameInMap("flowType")]
        [Validation(Required=false)]
        public string FlowType { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

        [NameInMap("subRoles")]
        [Validation(Required=false)]
        public List<UpdateRoleResponseBodySubRoles> SubRoles { get; set; }
        public class UpdateRoleResponseBodySubRoles : TeaModel {
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public int? AuthLevel { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public int? BizType { get; set; }

            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
