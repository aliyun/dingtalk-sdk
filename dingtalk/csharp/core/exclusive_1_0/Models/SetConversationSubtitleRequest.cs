// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SetConversationSubtitleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidxxxx</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>副标题</para>
        /// </summary>
        [NameInMap("subtitle")]
        [Validation(Required=false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>#0000FF</para>
        /// </summary>
        [NameInMap("subtitleColor")]
        [Validation(Required=false)]
        public string SubtitleColor { get; set; }

    }

}
