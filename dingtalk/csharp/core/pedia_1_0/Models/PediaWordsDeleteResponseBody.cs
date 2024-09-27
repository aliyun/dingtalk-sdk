// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsDeleteResponseBody : TeaModel {
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

    }

}
