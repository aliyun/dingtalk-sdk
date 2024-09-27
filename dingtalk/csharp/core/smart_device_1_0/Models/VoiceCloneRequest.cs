// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksmart_device_1_0.Models
{
    public class VoiceCloneRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>你好，我叫小智，是来自阿里云的超大规模语言模型。我是一个能够回答问题、创作文字，还能表达观点、撰写代码的全能型AI助手。如果您有任何问题或需要帮助，请随时告诉我，我会尽我所能为您提供帮助！</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manager4224</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qhtestvoice-01</para>
        /// </summary>
        [NameInMap("voiceId")]
        [Validation(Required=false)]
        public string VoiceId { get; set; }

    }

}
