// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class UpdateLiveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png">https://gw.alicdn.com/tfs/TB1thlYyAT2gK0jSZPcXXcKkpXa-1125-633.png</a></para>
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试直播简介</para>
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4d383876-1ff9-4b73-a057-a8f47b346ecb</para>
        /// </summary>
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1659653648000</para>
        /// </summary>
        [NameInMap("preEndTime")]
        [Validation(Required=false)]
        public long? PreEndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1659613648000</para>
        /// </summary>
        [NameInMap("preStartTime")]
        [Validation(Required=false)]
        public long? PreStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>测试直播</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC7wZGOSueEEIGOf3WKwWgiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
