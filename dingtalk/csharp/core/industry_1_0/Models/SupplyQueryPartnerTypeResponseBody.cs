// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyQueryPartnerTypeResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SupplyQueryPartnerTypeResponseBodyResult Result { get; set; }
        public class SupplyQueryPartnerTypeResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>21</para>
            /// </summary>
            [NameInMap("labelId")]
            [Validation(Required=false)]
            public long? LabelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>标签1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("superId")]
            [Validation(Required=false)]
            public long? SuperId { get; set; }

        }

    }

}
