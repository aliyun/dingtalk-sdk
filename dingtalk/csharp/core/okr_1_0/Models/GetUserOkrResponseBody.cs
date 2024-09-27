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

                /// <summary>
                /// <b>Example:</b>
                /// <para>Objective demo</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public Stream Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1648625407694</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public float? GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1648625407694</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public float? GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5dAX8</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }

                [NameInMap("krList")]
                [Validation(Required=false)]
                public List<GetUserOkrResponseBodyDataListKrList> KrList { get; set; }
                public class GetUserOkrResponseBodyDataListKrList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public Stream Content { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1648625407694</para>
                    /// </summary>
                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public float? GmtCreate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1648625407694</para>
                    /// </summary>
                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public float? GmtModified { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5w9f</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5wf8</para>
                    /// </summary>
                    [NameInMap("objectiveId")]
                    [Validation(Required=false)]
                    public Stream ObjectiveId { get; set; }

                    [NameInMap("permission")]
                    [Validation(Required=false)]
                    public List<float?> Permission { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>35614536</para>
                    /// </summary>
                    [NameInMap("position")]
                    [Validation(Required=false)]
                    public long? Position { get; set; }

                    [NameInMap("progress")]
                    [Validation(Required=false)]
                    public GetUserOkrResponseBodyDataListKrListProgress Progress { get; set; }
                    public class GetUserOkrResponseBodyDataListKrListProgress : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("percent")]
                        [Validation(Required=false)]
                        public int? Percent { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>44</para>
                    /// </summary>
                    [NameInMap("score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>44</para>
                    /// </summary>
                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public float? Weight { get; set; }

                }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public GetUserOkrResponseBodyDataListOwner Owner { get; set; }
                public class GetUserOkrResponseBodyDataListOwner : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>@lADPDh0cQ_j4Mi_NBULNBUA</para>
                    /// </summary>
                    [NameInMap("avatarMediaId")]
                    [Validation(Required=false)]
                    public Stream AvatarMediaId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ding4d1c8883ff63ee8124f2f5cc6abecb85</para>
                    /// </summary>
                    [NameInMap("corpId")]
                    [Validation(Required=false)]
                    public Stream CorpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>K1AMgq</para>
                    /// </summary>
                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public Stream Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>你好</para>
                    /// </summary>
                    [NameInMap("nickname")]
                    [Validation(Required=false)]
                    public Stream Nickname { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>06186238011033616</para>
                    /// </summary>
                    [NameInMap("userId")]
                    [Validation(Required=false)]
                    public Stream UserId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1006</para>
                /// </summary>
                [NameInMap("periodId")]
                [Validation(Required=false)]
                public Stream PeriodId { get; set; }

                [NameInMap("permission")]
                [Validation(Required=false)]
                public List<float?> Permission { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3021332</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public int? Position { get; set; }

                [NameInMap("progress")]
                [Validation(Required=false)]
                public GetUserOkrResponseBodyDataListProgress Progress { get; set; }
                public class GetUserOkrResponseBodyDataListProgress : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("percent")]
                    [Validation(Required=false)]
                    public int? Percent { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("progressPercent")]
                [Validation(Required=false)]
                public float? ProgressPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("published")]
                [Validation(Required=false)]
                public bool? Published { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>s34d</para>
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public Stream UserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public float? Weight { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
