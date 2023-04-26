// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class DeleteOrgTextEmotionRequest : TeaModel {
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("emotionIds")]
        [Validation(Required=false)]
        public List<string> EmotionIds { get; set; }

    }

}
