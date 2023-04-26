// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateEduAssetSpaceResponseBody : TeaModel {
        [NameInMap("createTimeMillis")]
        [Validation(Required=false)]
        public long? CreateTimeMillis { get; set; }

        [NameInMap("modifyTimeMillis")]
        [Validation(Required=false)]
        public long? ModifyTimeMillis { get; set; }

        [NameInMap("permissionMode")]
        [Validation(Required=false)]
        public string PermissionMode { get; set; }

        [NameInMap("quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        [NameInMap("spaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        [NameInMap("spaceType")]
        [Validation(Required=false)]
        public string SpaceType { get; set; }

        [NameInMap("usedQuota")]
        [Validation(Required=false)]
        public long? UsedQuota { get; set; }

    }

}
