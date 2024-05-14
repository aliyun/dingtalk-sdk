// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class OkrOpenRecommendResponseBody : TeaModel {
        [NameInMap("okrRecommendItems")]
        [Validation(Required=false)]
        public List<OkrOpenRecommendResponseBodyOkrRecommendItems> OkrRecommendItems { get; set; }
        public class OkrOpenRecommendResponseBodyOkrRecommendItems : TeaModel {
            [NameInMap("krResultRelatedResults")]
            [Validation(Required=false)]
            public List<OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults> KrResultRelatedResults { get; set; }
            public class OkrOpenRecommendResponseBodyOkrRecommendItemsKrResultRelatedResults : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("krId")]
                [Validation(Required=false)]
                public string KrId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("semanticLevel")]
                [Validation(Required=false)]
                public long? SemanticLevel { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("words")]
                [Validation(Required=false)]
                public List<string> Words { get; set; }

            }

            [NameInMap("objectiveRelatedResults")]
            [Validation(Required=false)]
            public List<OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults> ObjectiveRelatedResults { get; set; }
            public class OkrOpenRecommendResponseBodyOkrRecommendItemsObjectiveRelatedResults : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("objectiveId")]
                [Validation(Required=false)]
                public string ObjectiveId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("semanticLevel")]
                [Validation(Required=false)]
                public long? SemanticLevel { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("words")]
                [Validation(Required=false)]
                public List<string> Words { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("relatedLevel")]
            [Validation(Required=false)]
            public long? RelatedLevel { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("semanticLevel")]
            [Validation(Required=false)]
            public long? SemanticLevel { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
