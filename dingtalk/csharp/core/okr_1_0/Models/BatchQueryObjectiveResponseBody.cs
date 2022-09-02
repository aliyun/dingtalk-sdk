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
        public List<BatchQueryObjectiveResponseBodyData> Data { get; set; }
        public class BatchQueryObjectiveResponseBodyData : TeaModel {
            /// <summary>
            /// 被对齐的 Objective。
            /// </summary>
            [NameInMap("alignFromIds")]
            [Validation(Required=false)]
            public List<Stream> AlignFromIds { get; set; }

            /// <summary>
            /// 对齐的 Objective。
            /// </summary>
            [NameInMap("alignToIds")]
            [Validation(Required=false)]
            public List<Stream> AlignToIds { get; set; }

            /// <summary>
            /// Objective 内容。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public Stream Content { get; set; }

            /// <summary>
            /// 创建时间。时间戳
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public float? GmtCreate { get; set; }

            /// <summary>
            /// 更新时间。时间戳
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public float? GmtModified { get; set; }

            /// <summary>
            /// objective。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            /// <summary>
            /// KR 详情列表。
            /// </summary>
            [NameInMap("krList")]
            [Validation(Required=false)]
            public List<BatchQueryObjectiveResponseBodyDataKrList> KrList { get; set; }
            public class BatchQueryObjectiveResponseBodyDataKrList : TeaModel {
                /// <summary>
                /// KR 内容。
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public Stream Content { get; set; }

                /// <summary>
                /// 创建时间。时间戳
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public float? GmtCreate { get; set; }

                /// <summary>
                /// 更新时间。时间戳
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public float? GmtModified { get; set; }

                /// <summary>
                /// KR 的 ID。
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }

                /// <summary>
                /// 所属 Objective ID。
                /// </summary>
                [NameInMap("objectiveId")]
                [Validation(Required=false)]
                public Stream ObjectiveId { get; set; }

                /// <summary>
                /// KR 权限。
                /// </summary>
                [NameInMap("permission")]
                [Validation(Required=false)]
                public List<float?> Permission { get; set; }

                /// <summary>
                /// 所处位置。
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public long? Position { get; set; }

                /// <summary>
                /// KR 进度。
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public BatchQueryObjectiveResponseBodyDataKrListProgress Progress { get; set; }
                public class BatchQueryObjectiveResponseBodyDataKrListProgress : TeaModel {
                    /// <summary>
                    /// 百分比。
                    /// </summary>
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                }

                /// <summary>
                /// 所占分数。
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// 所占权重。
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            /// <summary>
            /// 所属者信息。
            /// </summary>
            [NameInMap("owner")]
            [Validation(Required=false)]
            public BatchQueryObjectiveResponseBodyDataOwner Owner { get; set; }
            public class BatchQueryObjectiveResponseBodyDataOwner : TeaModel {
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
                /// 所属者在 OKR 系统中的 ID。
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

            /// <summary>
            /// 周期 ID。
            /// </summary>
            [NameInMap("periodId")]
            [Validation(Required=false)]
            public Stream PeriodId { get; set; }

            /// <summary>
            /// 权限值。
            /// </summary>
            [NameInMap("permission")]
            [Validation(Required=false)]
            public List<float?> Permission { get; set; }

            /// <summary>
            /// 所在位置。
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            /// <summary>
            /// 进度值。
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public BatchQueryObjectiveResponseBodyDataProgress Progress { get; set; }
            public class BatchQueryObjectiveResponseBodyDataProgress : TeaModel {
                /// <summary>
                /// 百分比。
                /// </summary>
                [NameInMap("percent")]
                [Validation(Required=false)]
                public int? Percent { get; set; }

            }

            /// <summary>
            /// 百分比值。
            /// </summary>
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public float? ProgressPercent { get; set; }

            /// <summary>
            /// 是否已发布。
            /// </summary>
            [NameInMap("published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// 分数值。
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// 当前内容状态。
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 用户 ID。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public Stream UserId { get; set; }

            /// <summary>
            /// 权重值。
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
