// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class LoginForVisitorRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>uuid_a123</para>
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>your_channel_code</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc123xyz</para>
        /// </summary>
        [NameInMap("customAccessToken")]
        [Validation(Required=false)]
        public string CustomAccessToken { get; set; }

    }

}
