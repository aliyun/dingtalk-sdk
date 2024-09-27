// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListPartnerAdminsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SupplyListPartnerAdminsResponseBodyResult> Result { get; set; }
        public class SupplyListPartnerAdminsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>负责人名称</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>99292111</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8782166278711</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
