// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetCorrectStyleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetCorrectStyleResponseBodyResult Result { get; set; }
        public class GetCorrectStyleResponseBodyResult : TeaModel {
            [NameInMap("checkSizeType")]
            [Validation(Required=false)]
            public string CheckSizeType { get; set; }

            [NameInMap("halfCheckSizeType")]
            [Validation(Required=false)]
            public string HalfCheckSizeType { get; set; }

            [NameInMap("showPaperScore")]
            [Validation(Required=false)]
            public bool? ShowPaperScore { get; set; }

            [NameInMap("subScoreDisplayType")]
            [Validation(Required=false)]
            public string SubScoreDisplayType { get; set; }

            [NameInMap("wrongSizeType")]
            [Validation(Required=false)]
            public string WrongSizeType { get; set; }

            [NameInMap("wrongStyle")]
            [Validation(Required=false)]
            public string WrongStyle { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
