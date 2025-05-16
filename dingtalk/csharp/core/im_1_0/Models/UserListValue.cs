// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UserListValue : TeaModel {
        [NameInMap("joinTime")]
        [Validation(Required=false)]
        public long? JoinTime { get; set; }

        [NameInMap("modifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        [NameInMap("mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        [NameInMap("topRank")]
        [Validation(Required=false)]
        public bool? TopRank { get; set; }

        [NameInMap("visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

    }

}
