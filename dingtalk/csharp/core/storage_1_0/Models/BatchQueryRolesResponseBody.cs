// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_1_0.Models
{
    public class BatchQueryRolesResponseBody : TeaModel {
        [NameInMap("roleMap")]
        [Validation(Required=false)]
        public Dictionary<string, List<RoleMapValue>> RoleMap { get; set; }

    }

}
