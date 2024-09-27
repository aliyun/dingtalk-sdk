// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class TopboxOpenRequest : TeaModel {
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1850042969000</para>
        /// </summary>
        [NameInMap("expiredTime")]
        [Validation(Required=false)]
        public long? ExpiredTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ios|win</para>
        /// </summary>
        [NameInMap("platforms")]
        [Validation(Required=false)]
        public string Platforms { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("receiverUserIdList")]
        [Validation(Required=false)]
        public List<string> ReceiverUserIdList { get; set; }

        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
