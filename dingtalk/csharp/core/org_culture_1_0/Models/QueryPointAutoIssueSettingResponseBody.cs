// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointAutoIssueSettingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointAutoIssueSettingResponseBodyResult Result { get; set; }
        public class QueryPointAutoIssueSettingResponseBodyResult : TeaModel {
            [NameInMap("pointAutoNum")]
            [Validation(Required=false)]
            public long? PointAutoNum { get; set; }
            [NameInMap("pointAutoState")]
            [Validation(Required=false)]
            public bool? PointAutoState { get; set; }
            [NameInMap("pointAutoTime")]
            [Validation(Required=false)]
            public long? PointAutoTime { get; set; }
        };

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
