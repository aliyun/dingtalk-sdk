// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class MasterDataTenantQueyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<MasterDataTenantQueyResponseBodyResult> Result { get; set; }
        public class MasterDataTenantQueyResponseBodyResult : TeaModel {
            /// <summary>
            /// 该租户是否已向主数据同步数据
            /// </summary>
            [NameInMap("hasData")]
            [Validation(Required=false)]
            public bool? HasData { get; set; }

            /// <summary>
            /// 该租户是否有向主数据写数据的权限
            /// </summary>
            [NameInMap("integrateDataAuth")]
            [Validation(Required=false)]
            public bool? IntegrateDataAuth { get; set; }

            /// <summary>
            /// 租户名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 调用方是否有读该租户数据的权限
            /// </summary>
            [NameInMap("readAuth")]
            [Validation(Required=false)]
            public bool? ReadAuth { get; set; }

            /// <summary>
            /// 租户 id
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public long? TenantId { get; set; }

            /// <summary>
            /// 租户类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

    }

}
