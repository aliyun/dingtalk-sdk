// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateEduAssetSpaceRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("spaceDesc")]
        [Validation(Required=false)]
        public string SpaceDesc { get; set; }

        [NameInMap("spaceIcon")]
        [Validation(Required=false)]
        public string SpaceIcon { get; set; }

        [NameInMap("spaceName")]
        [Validation(Required=false)]
        public string SpaceName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
