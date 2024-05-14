// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataTenantQueyResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDataTenantQueyResponseBodyResult> Result { get; set; }
        public class MasterDataTenantQueyResponseBodyResult : TeaModel {
            [NameInMap("hasData")]
            [Validation(Required=false)]
            public bool? HasData { get; set; }

            [NameInMap("integrateDataAuth")]
            [Validation(Required=false)]
            public bool? IntegrateDataAuth { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("readAuth")]
            [Validation(Required=false)]
            public bool? ReadAuth { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
