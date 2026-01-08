// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateConvNavTabRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("mobileUrl")]
        [Validation(Required=false)]
        public string MobileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidc4iLyQBuHFQRvzxznz204Q</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
        /// </summary>
        [NameInMap("pcUrl")]
        [Validation(Required=false)]
        public string PcUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>409021</para>
        /// </summary>
        [NameInMap("tabId")]
        [Validation(Required=false)]
        public string TabId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例标签页</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userEditable")]
        [Validation(Required=false)]
        public bool? UserEditable { get; set; }

    }

}
