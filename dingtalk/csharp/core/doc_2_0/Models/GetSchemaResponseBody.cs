// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class GetSchemaResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;{&quot;pageVersion&quot;:&quot;1.0.0&quot;,&quot;pageSchema&quot;:{&quot;version&quot;:&quot;1.0.0&quot;,&quot;componentsMap&quot;:[],&quot;componentsTree&quot;:[]}}&quot;</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
