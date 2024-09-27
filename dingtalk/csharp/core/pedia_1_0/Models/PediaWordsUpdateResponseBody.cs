// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkpedia_1_0.Models
{
    public class PediaWordsUpdateResponseBody : TeaModel {
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3213213213</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public long? Uuid { get; set; }

    }

}
