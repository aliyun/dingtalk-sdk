// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryObjectiveResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<BatchQueryObjectiveResponseBodyData> Data { get; set; }
        public class BatchQueryObjectiveResponseBodyData : TeaModel {
            [NameInMap("alignFromIds")]
            [Validation(Required=false)]
            public List<Stream> AlignFromIds { get; set; }

            [NameInMap("alignToIds")]
            [Validation(Required=false)]
            public List<Stream> AlignToIds { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public Stream Content { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            [NameInMap("krList")]
            [Validation(Required=false)]
            public List<BatchQueryObjectiveResponseBodyDataKrList> KrList { get; set; }
            public class BatchQueryObjectiveResponseBodyDataKrList : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public Stream Content { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }

                [NameInMap("objectiveId")]
                [Validation(Required=false)]
                public Stream ObjectiveId { get; set; }

                [NameInMap("permission")]
                [Validation(Required=false)]
                public List<float?> Permission { get; set; }

                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                [NameInMap("progress")]
                [Validation(Required=false)]
                public BatchQueryObjectiveResponseBodyDataKrListProgress Progress { get; set; }
                public class BatchQueryObjectiveResponseBodyDataKrListProgress : TeaModel {
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }
                };

                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public BatchQueryObjectiveResponseBodyDataOwner Owner { get; set; }
            public class BatchQueryObjectiveResponseBodyDataOwner : TeaModel {
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public Stream AvatarMediaId { get; set; }
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public Stream CorpId { get; set; }
                [NameInMap("department")]
                [Validation(Required=false)]
                public BatchQueryObjectiveResponseBodyDataOwnerDepartment Department { get; set; }
                public class BatchQueryObjectiveResponseBodyDataOwnerDepartment : TeaModel {
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public Stream Name { get; set; }

                }
                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }
                [NameInMap("nickname")]
                [Validation(Required=false)]
                public Stream Nickname { get; set; }
                [NameInMap("staffId")]
                [Validation(Required=false)]
                public Stream StaffId { get; set; }
            };

            [NameInMap("periodId")]
            [Validation(Required=false)]
            public Stream PeriodId { get; set; }

            [NameInMap("permission")]
            [Validation(Required=false)]
            public List<float?> Permission { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            [NameInMap("progress")]
            [Validation(Required=false)]
            public BatchQueryObjectiveResponseBodyDataProgress Progress { get; set; }
            public class BatchQueryObjectiveResponseBodyDataProgress : TeaModel {
                [NameInMap("percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }
            };

            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public float? ProgressPercent { get; set; }

            [NameInMap("published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public Stream UserId { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

        }

        /// <summary>
        /// message
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public Stream Message { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
