// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetConversationUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1107****2120</para>
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oK4e****qER2</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123**789</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f67b****8a0f</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1745****8777</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
