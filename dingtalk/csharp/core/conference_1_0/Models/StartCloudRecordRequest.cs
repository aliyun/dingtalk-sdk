// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class StartCloudRecordRequest : TeaModel {
        /// <summary>
        /// 录制模版
        /// </summary>
        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// 小窗位置
        /// </summary>
        [NameInMap("smallWindowPosition")]
        [Validation(Required=false)]
        public string SmallWindowPosition { get; set; }

        /// <summary>
        /// 会议发起人UID
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
