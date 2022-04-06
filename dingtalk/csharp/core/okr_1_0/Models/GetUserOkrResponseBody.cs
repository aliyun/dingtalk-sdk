// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetUserOkrResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetUserOkrResponseBodyData Data { get; set; }
        public class GetUserOkrResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<GetUserOkrResponseBodyDataList> List { get; set; }
            public class GetUserOkrResponseBodyDataList : TeaModel {
                public List<string> AlignFromIds { get; set; }
                public List<string> AlignToIds { get; set; }
                public Stream Content { get; set; }
                public float? GmtCreate { get; set; }
                public float? GmtModified { get; set; }
                public Stream Id { get; set; }
                public List<GetUserOkrResponseBodyDataListKrList> KrList { get; set; }
                public class GetUserOkrResponseBodyDataListKrList : TeaModel {
                    public Stream Content { get; set; }
                    public float? GmtCreate { get; set; }
                    public float? GmtModified { get; set; }
                    public Stream Id { get; set; }
                    public Stream ObjectiveId { get; set; }
                    public List<string> Permission { get; set; }
                    public long? Position { get; set; }
                    public GetUserOkrResponseBodyDataListKrListProgress Progress { get; set; }
                    public class GetUserOkrResponseBodyDataListKrListProgress : TeaModel {
                        /// <summary>
                        /// 百分比。
                        /// </summary>
                        [NameInMap("percent")]
                        [Validation(Required=false)]
                        public int? Percent { get; set; }

                    }
                    public float? Score { get; set; }
                    public float? Weight { get; set; }
                }
                public GetUserOkrResponseBodyDataListOwner Owner { get; set; }
                public class GetUserOkrResponseBodyDataListOwner : TeaModel {
                    /// <summary>
                    /// 所属者头像。 ID
                    /// </summary>
                    [NameInMap("avatarMediaId")]
                    [Validation(Required=false)]
                    public Stream AvatarMediaId { get; set; }

                    /// <summary>
                    /// 所属者组织 I。D
                    /// </summary>
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public Stream CorpId { get; set; }

                    /// <summary>
                    /// 所属者 OKR 系统中的 ID。
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    /// <summary>
                    /// 所属者昵称。
                    /// </summary>
                    [NameInMap("nickname")]
                    [Validation(Required=false)]
                    public Stream Nickname { get; set; }

                    /// <summary>
                    /// 所属者 userId。
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public Stream UserId { get; set; }

                }
                public Stream PeriodId { get; set; }
                public List<string> Permission { get; set; }
                public int? Position { get; set; }
                public GetUserOkrResponseBodyDataListProgress Progress { get; set; }
                public class GetUserOkrResponseBodyDataListProgress : TeaModel {
                    /// <summary>
                    /// 百分比。
                    /// </summary>
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                }
                public float? ProgressPercent { get; set; }
                public bool? Published { get; set; }
                public float? Score { get; set; }
                public int? Status { get; set; }
                public Stream UserId { get; set; }
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
        };

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
