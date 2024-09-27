// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class QueryItemByUrlRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>YEp3JcM******UIbhwiE</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://alidocs.dingtalk.com/i/nodes/m0Xw6OYE4D7VLeaBP">https://alidocs.dingtalk.com/i/nodes/m0Xw6OYE4D7VLeaBP</a>***</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        [NameInMap("withStatisticalInfo")]
        [Validation(Required=false)]
        public bool? WithStatisticalInfo { get; set; }

    }

}
