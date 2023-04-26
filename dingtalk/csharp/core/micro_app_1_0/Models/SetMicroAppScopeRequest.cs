// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class SetMicroAppScopeRequest : TeaModel {
        [NameInMap("addDeptIds")]
        [Validation(Required=false)]
        public List<long?> AddDeptIds { get; set; }

        [NameInMap("addRoleIds")]
        [Validation(Required=false)]
        public List<long?> AddRoleIds { get; set; }

        [NameInMap("addUserIds")]
        [Validation(Required=false)]
        public List<string> AddUserIds { get; set; }

        [NameInMap("delDeptIds")]
        [Validation(Required=false)]
        public List<long?> DelDeptIds { get; set; }

        [NameInMap("delRoleIds")]
        [Validation(Required=false)]
        public List<long?> DelRoleIds { get; set; }

        [NameInMap("delUserIds")]
        [Validation(Required=false)]
        public List<string> DelUserIds { get; set; }

        [NameInMap("onlyAdminVisible")]
        [Validation(Required=false)]
        public bool? OnlyAdminVisible { get; set; }

    }

}
