// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class ExecuteAgentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ExecuteAgentResponseBodyResult Result { get; set; }
        public class ExecuteAgentResponseBodyResult : TeaModel {
            [NameInMap("executeResult")]
            [Validation(Required=false)]
            public string ExecuteResult { get; set; }

            [NameInMap("skillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

        }

    }

}
