// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class BatchCreateResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchCreateResponseBodyResult Result { get; set; }
        public class BatchCreateResponseBodyResult : TeaModel {
            [NameInMap("corpIdCardIdMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> CorpIdCardIdMap { get; set; }
        };

    }

}
