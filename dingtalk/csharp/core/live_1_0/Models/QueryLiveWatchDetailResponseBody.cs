// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class QueryLiveWatchDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryLiveWatchDetailResponseBodyResult Result { get; set; }
        public class QueryLiveWatchDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3560</para>
            /// </summary>
            [NameInMap("avgWatchTime")]
            [Validation(Required=false)]
            public long? AvgWatchTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>55</para>
            /// </summary>
            [NameInMap("liveUv")]
            [Validation(Required=false)]
            public int? LiveUv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>252</para>
            /// </summary>
            [NameInMap("msgCount")]
            [Validation(Required=false)]
            public int? MsgCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>72</para>
            /// </summary>
            [NameInMap("playbackUv")]
            [Validation(Required=false)]
            public int? PlaybackUv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public int? PraiseCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("pv")]
            [Validation(Required=false)]
            public int? Pv { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1903640</para>
            /// </summary>
            [NameInMap("totalWatchTime")]
            [Validation(Required=false)]
            public long? TotalWatchTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("uv")]
            [Validation(Required=false)]
            public int? Uv { get; set; }

        }

    }

}
