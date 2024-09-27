// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class BatchQueryUserResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<BatchQueryUserResponseBodyData> Data { get; set; }
        public class BatchQueryUserResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>@lADPDh0cQ_j4Mi_NBULNBUA</para>
            /// </summary>
            [NameInMap("avatarMediaId")]
            [Validation(Required=false)]
            public Stream AvatarMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/lADPEj_RiGhUdKjNC9TNC9A_3024_3028.jpg_620x10000q90.jpg">https://static.dingtalk.com/media/lADPEj_RiGhUdKjNC9TNC9A_3024_3028.jpg_620x10000q90.jpg</a></para>
            /// </summary>
            [NameInMap("avatarUrl")]
            [Validation(Required=false)]
            public Stream AvatarUrl { get; set; }

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
