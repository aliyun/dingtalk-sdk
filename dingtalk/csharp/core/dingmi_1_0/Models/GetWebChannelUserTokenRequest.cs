// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class GetWebChannelUserTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123abc</para>
        /// </summary>
        [NameInMap("foreignId")]
        [Validation(Required=false)]
        public string ForeignId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>客户abc</para>
        /// </summary>
        [NameInMap("nick")]
        [Validation(Required=false)]
        public string Nick { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

    }

}
