// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0.Models
{
    public class OkrOpenRecommendRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("candidateOkrItems")]
        [Validation(Required=false)]
        public List<OkrOpenRecommendRequestCandidateOkrItems> CandidateOkrItems { get; set; }
        public class OkrOpenRecommendRequestCandidateOkrItems : TeaModel {
            [NameInMap("okrInfos")]
            [Validation(Required=false)]
            public List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfos> OkrInfos { get; set; }
            public class OkrOpenRecommendRequestCandidateOkrItemsOkrInfos : TeaModel {
                [NameInMap("keyResultInfos")]
                [Validation(Required=false)]
                public List<OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos> KeyResultInfos { get; set; }
                public class OkrOpenRecommendRequestCandidateOkrItemsOkrInfosKeyResultInfos : TeaModel {
                    [NameInMap("kr")]
                    [Validation(Required=false)]
                    public string Kr { get; set; }

                    [NameInMap("krId")]
                    [Validation(Required=false)]
                    public string KrId { get; set; }

                    [NameInMap("words")]
                    [Validation(Required=false)]
                    public List<string> Words { get; set; }

                }

                [NameInMap("objective")]
                [Validation(Required=false)]
                public string Objective { get; set; }

                [NameInMap("objectiveId")]
                [Validation(Required=false)]
                public string ObjectiveId { get; set; }

                [NameInMap("words")]
                [Validation(Required=false)]
                public List<string> Words { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deptIds")]
        [Validation(Required=false)]
        public List<string> DeptIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isvAppId")]
        [Validation(Required=false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("words")]
        [Validation(Required=false)]
        public List<string> Words { get; set; }

    }

}
