// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PageQueryKitOpenRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<PageQueryKitOpenRecordResponseBodyResult> Result { get; set; }
        public class PageQueryKitOpenRecordResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingxxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ISV_XXX</para>
            /// </summary>
            [NameInMap("isvCode")]
            [Validation(Required=false)]
            public string IsvCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>course</para>
            /// </summary>
            [NameInMap("isvProductScene")]
            [Validation(Required=false)]
            public string IsvProductScene { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-20 00:00:00</para>
            /// </summary>
            [NameInMap("openEndTime")]
            [Validation(Required=false)]
            public string OpenEndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-20 00:00:00</para>
            /// </summary>
            [NameInMap("openStartTime")]
            [Validation(Required=false)]
            public string OpenStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>staffxxx</para>
            /// </summary>
            [NameInMap("openUserId")]
            [Validation(Required=false)]
            public string OpenUserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
