// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class EditFeedReplayRequest : TeaModel {
        [NameInMap("editEndTime")]
        [Validation(Required=false)]
        public long? EditEndTime { get; set; }

        [NameInMap("editStartTime")]
        [Validation(Required=false)]
        public long? EditStartTime { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
