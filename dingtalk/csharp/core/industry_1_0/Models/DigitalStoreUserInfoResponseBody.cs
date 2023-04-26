// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreUserInfoResponseBody : TeaModel {
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("roleIdList")]
        [Validation(Required=false)]
        public List<long?> RoleIdList { get; set; }

        [NameInMap("scopeList")]
        [Validation(Required=false)]
        public List<long?> ScopeList { get; set; }

        [NameInMap("storeList")]
        [Validation(Required=false)]
        public List<long?> StoreList { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
