// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class CreateAclsResponseBody : TeaModel {
        /// <summary>
        /// acl资源ID
        /// </summary>
        [NameInMap("aclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// 对日历的访问权限
        /// </summary>
        [NameInMap("privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

        /// <summary>
        /// 权限范围
        /// </summary>
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
        };

    }

}
