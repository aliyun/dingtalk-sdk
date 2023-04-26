// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddOrgTextEmotionRequest : TeaModel {
        [NameInMap("backgroundMediaId")]
        [Validation(Required=false)]
        public string BackgroundMediaId { get; set; }

        [NameInMap("backgroundMediaIdForPanel")]
        [Validation(Required=false)]
        public string BackgroundMediaIdForPanel { get; set; }

        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("emotionName")]
        [Validation(Required=false)]
        public string EmotionName { get; set; }

    }

}
