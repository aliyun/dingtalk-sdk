// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class EditFeedReplayRequest : TeaModel {
        /// <summary>
        /// 剪辑的结束位置的时间戳（在原开始结束的时间戳之内）
        /// </summary>
        [NameInMap("editEndTime")]
        [Validation(Required=false)]
        public long? EditEndTime { get; set; }

        /// <summary>
        /// 剪辑的起始位置的时间戳（在原开始结束的时间戳之内）
        /// </summary>
        [NameInMap("editStartTime")]
        [Validation(Required=false)]
        public long? EditStartTime { get; set; }

        /// <summary>
        /// 用户id(剪辑者的组织内id)
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
