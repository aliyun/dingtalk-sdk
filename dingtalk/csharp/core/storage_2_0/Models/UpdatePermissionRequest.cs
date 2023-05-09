// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkstorage_2_0.Models
{
    public class UpdatePermissionRequest : TeaModel {
        [NameInMap("members")]
        [Validation(Required=false)]
        public List<UpdatePermissionRequestMembers> Members { get; set; }
        public class UpdatePermissionRequestMembers : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("option")]
        [Validation(Required=false)]
        public UpdatePermissionRequestOption Option { get; set; }
        public class UpdatePermissionRequestOption : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

        }

        [NameInMap("roleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
