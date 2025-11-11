// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class AiTrainingDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AiTrainingDetailResponseBodyResult Result { get; set; }
        public class AiTrainingDetailResponseBodyResult : TeaModel {
            [NameInMap("adminReview")]
            [Validation(Required=false)]
            public string AdminReview { get; set; }

            [NameInMap("aiJobStatus")]
            [Validation(Required=false)]
            public string AiJobStatus { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("feedback")]
            [Validation(Required=false)]
            public long? Feedback { get; set; }

            [NameInMap("feedbackContent")]
            [Validation(Required=false)]
            public string FeedbackContent { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("isExcellent")]
            [Validation(Required=false)]
            public long? IsExcellent { get; set; }

            [NameInMap("productInfoList")]
            [Validation(Required=false)]
            public List<AiTrainingDetailResponseBodyResultProductInfoList> ProductInfoList { get; set; }
            public class AiTrainingDetailResponseBodyResultProductInfoList : TeaModel {
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("productCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("productId")]
                [Validation(Required=false)]
                public long? ProductId { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("taskInfo")]
            [Validation(Required=false)]
            public AiTrainingDetailResponseBodyResultTaskInfo TaskInfo { get; set; }
            public class AiTrainingDetailResponseBodyResultTaskInfo : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("taskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("taskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

            }

            [NameInMap("trainingRanking")]
            [Validation(Required=false)]
            public long? TrainingRanking { get; set; }

            [NameInMap("trainingRankingPercent")]
            [Validation(Required=false)]
            public long? TrainingRankingPercent { get; set; }

            [NameInMap("trainingScore")]
            [Validation(Required=false)]
            public long? TrainingScore { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("videoDownloadUrl")]
            [Validation(Required=false)]
            public string VideoDownloadUrl { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
