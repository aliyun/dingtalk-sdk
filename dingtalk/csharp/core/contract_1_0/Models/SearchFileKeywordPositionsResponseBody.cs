// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SearchFileKeywordPositionsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SearchFileKeywordPositionsResponseBodyResult Result { get; set; }
        public class SearchFileKeywordPositionsResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public SearchFileKeywordPositionsResponseBodyResultData Data { get; set; }
            public class SearchFileKeywordPositionsResponseBodyResultData : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("keyword")]
                [Validation(Required=false)]
                public string Keyword { get; set; }

                [NameInMap("positions")]
                [Validation(Required=false)]
                public List<SearchFileKeywordPositionsResponseBodyResultDataPositions> Positions { get; set; }
                public class SearchFileKeywordPositionsResponseBodyResultDataPositions : TeaModel {
                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("positionPage")]
                    [Validation(Required=false)]
                    public int? PositionPage { get; set; }

                    [NameInMap("positionX")]
                    [Validation(Required=false)]
                    public double? PositionX { get; set; }

                    [NameInMap("positionY")]
                    [Validation(Required=false)]
                    public double? PositionY { get; set; }

                }

                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
