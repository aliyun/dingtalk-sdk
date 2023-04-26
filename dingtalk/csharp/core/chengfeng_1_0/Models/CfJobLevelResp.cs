// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class CfJobLevelResp : TeaModel {
        [NameInMap("level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("stopDate")]
        [Validation(Required=false)]
        public string StopDate { get; set; }

    }

}
