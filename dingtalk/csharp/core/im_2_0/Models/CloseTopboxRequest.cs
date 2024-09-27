// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_2_0.Models
{
    public class CloseTopboxRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("conversationType")]
        [Validation(Required=false)]
        public int? ConversationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>COOLAPP-x-xxx</para>
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6dx-xxx-xxx</para>
        /// </summary>
        [NameInMap("groupTemplateId")]
        [Validation(Required=false)]
        public string GroupTemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxxxx==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123xxx</para>
        /// </summary>
        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingxxx</para>
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>jHsR7xxx</para>
        /// </summary>
        [NameInMap("unoinId")]
        [Validation(Required=false)]
        public string UnoinId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>011xxx</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
