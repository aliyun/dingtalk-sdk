// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryObjectiveResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public BatchQueryObjectiveResponseBodyData Data { get; set; }
        public class BatchQueryObjectiveResponseBodyData : TeaModel {
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<BatchQueryObjectiveResponseBodyDataList> List { get; set; }
            public class BatchQueryObjectiveResponseBodyDataList : TeaModel {
                public List<string> AlignFromIds { get; set; }
                public List<string> AlignToIds { get; set; }
                public Stream Content { get; set; }
                public Stream Id { get; set; }
                public List<BatchQueryObjectiveResponseBodyDataListKrList> KrList { get; set; }
                public class BatchQueryObjectiveResponseBodyDataListKrList : TeaModel {
                    public Stream Content { get; set; }
                    public Stream Id { get; set; }
                    public Stream ObjectiveId { get; set; }
                    public List<string> Permission { get; set; }
                    public long? Position { get; set; }
                    public BatchQueryObjectiveResponseBodyDataListKrListProgress Progress { get; set; }
                    public class BatchQueryObjectiveResponseBodyDataListKrListProgress : TeaModel {
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
                public BatchQueryObjectiveResponseBodyDataListOwner Owner { get; set; }
                public class BatchQueryObjectiveResponseBodyDataListOwner : TeaModel {
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
                    /// 所属者 ID。
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
                    [NameInMap("staffId")]
                    [Validation(Required=false)]
                    public Stream StaffId { get; set; }

                }
                public Stream PeriodId { get; set; }
                public List<string> Permission { get; set; }
                public int? Position { get; set; }
                public BatchQueryObjectiveResponseBodyDataListProgress Progress { get; set; }
                public class BatchQueryObjectiveResponseBodyDataListProgress : TeaModel {
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
            [NameInMap("pageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }
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
