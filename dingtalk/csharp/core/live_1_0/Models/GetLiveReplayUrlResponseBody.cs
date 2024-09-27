// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class GetLiveReplayUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetLiveReplayUrlResponseBodyResult Result { get; set; }
        public class GetLiveReplayUrlResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx">http://xxx.dingtalk.com/live_hp/7c7ba32a-c92d-4524-b71e-33a72575c5a9_normal.m3u8?auth_key=xxx</a></para>
            /// </summary>
            [NameInMap("replayUrl")]
            [Validation(Required=false)]
            public string ReplayUrl { get; set; }

        }

    }

}
