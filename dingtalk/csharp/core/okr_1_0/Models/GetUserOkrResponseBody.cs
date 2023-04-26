// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetUserOkrResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUserOkrResponseBodyData Data { get; set; }
        public class GetUserOkrResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetUserOkrResponseBodyDataList> List { get; set; }
            public class GetUserOkrResponseBodyDataList : TeaModel {
                [NameInMap("alignFromIds")]
                [Validation(Required=false)]
                public List<Stream> AlignFromIds { get; set; }

                [NameInMap("alignToIds")]
                [Validation(Required=false)]
                public List<Stream> AlignToIds { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public Stream Content { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public float? GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public float? GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }

                [NameInMap("krList")]
                [Validation(Required=false)]
                public List<GetUserOkrResponseBodyDataListKrList> KrList { get; set; }
                public class GetUserOkrResponseBodyDataListKrList : TeaModel {
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public Stream Content { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public float? GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public float? GmtModified { get; set; }

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
                    public GetUserOkrResponseBodyDataListKrListProgress Progress { get; set; }
                    public class GetUserOkrResponseBodyDataListKrListProgress : TeaModel {
                        [NameInMap("percent")]
                        [Validation(Required=false)]
                        public int? Percent { get; set; }

                    }

                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public float? Weight { get; set; }

                }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public GetUserOkrResponseBodyDataListOwner Owner { get; set; }
                public class GetUserOkrResponseBodyDataListOwner : TeaModel {
                    [NameInMap("avatarMediaId")]
                    [Validation(Required=false)]
                    public Stream AvatarMediaId { get; set; }

                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public Stream CorpId { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    [NameInMap("nickname")]
                    [Validation(Required=false)]
                    public Stream Nickname { get; set; }

                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public Stream UserId { get; set; }

                }

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
                public GetUserOkrResponseBodyDataListProgress Progress { get; set; }
                public class GetUserOkrResponseBodyDataListProgress : TeaModel {
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                }

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

            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
