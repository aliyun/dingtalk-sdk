// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class AiTrainingRecordResponseBody : TeaModel {
        [NameInMap("direction")]
        [Validation(Required=false)]
        public int? Direction { get; set; }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("lastId")]
        [Validation(Required=false)]
        public long? LastId { get; set; }

        [NameInMap("trainingList")]
        [Validation(Required=false)]
        public List<AiTrainingRecordResponseBodyTrainingList> TrainingList { get; set; }
        public class AiTrainingRecordResponseBodyTrainingList : TeaModel {
            [NameInMap("aiJobStatus")]
            [Validation(Required=false)]
            public string AiJobStatus { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("trainingRanking")]
            [Validation(Required=false)]
            public int? TrainingRanking { get; set; }

            [NameInMap("trainingRankingPercent")]
            [Validation(Required=false)]
            public int? TrainingRankingPercent { get; set; }

            [NameInMap("trainingScore")]
            [Validation(Required=false)]
            public int? TrainingScore { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
