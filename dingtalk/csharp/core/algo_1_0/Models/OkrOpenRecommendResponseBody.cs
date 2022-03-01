// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class OkrOpenRecommendResponseBody : TeaModel {
        /// <summary>
        /// okrRecommendItems
        /// </summary>
        [NameInMap("okrRecommendItems")]
        [Validation(Required=false)]
        public List<OkrOpenRecommendResponseBodyOkrRecommendItems> OkrRecommendItems { get; set; }
        public class OkrOpenRecommendResponseBodyOkrRecommendItems : TeaModel {
            /// <summary>
            /// userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// relatedLevel
            /// </summary>
            [NameInMap("relatedLevel")]
            [Validation(Required=false)]
            public long? RelatedLevel { get; set; }

            /// <summary>
            /// objectiveRelatedResults
            /// </summary>
            [NameInMap("objectiveRelatedResults")]
            [Validation(Required=false)]
            public List<OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults> ObjectiveRelatedResults { get; set; }
            public class OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults : TeaModel {
                /// <summary>
                /// objectiveId
                /// </summary>
                [NameInMap("objectiveId")]
                [Validation(Required=false)]
                public string ObjectiveId { get; set; }

                /// <summary>
                /// words
                /// </summary>
                [NameInMap("words")]
                [Validation(Required=false)]
                public List<string> Words { get; set; }

            }

            /// <summary>
            /// krResultRelatedResults
            /// </summary>
            [NameInMap("krResultRelatedResults")]
            [Validation(Required=false)]
            public List<OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults> KrResultRelatedResults { get; set; }
            public class OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults : TeaModel {
                /// <summary>
                /// krId
                /// </summary>
                [NameInMap("krId")]
                [Validation(Required=false)]
                public string KrId { get; set; }

                /// <summary>
                /// words
                /// </summary>
                [NameInMap("words")]
                [Validation(Required=false)]
                public List<string> Words { get; set; }

            }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
