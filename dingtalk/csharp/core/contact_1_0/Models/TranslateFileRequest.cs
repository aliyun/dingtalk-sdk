// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class TranslateFileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;#iAEHAqRmaWxlA6h5dW5kaXNrMAT&quot;:&quot;导出.xlsx&quot;}</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("medias")]
        [Validation(Required=false)]
        public Dictionary<string, string> Medias { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>学习手册</para>
        /// </summary>
        [NameInMap("outputFileName")]
        [Validation(Required=false)]
        public string OutputFileName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fXRUNiSlgfK3e1hzFUSciiJwiEiE</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
