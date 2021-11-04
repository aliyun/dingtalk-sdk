// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class GetQuotaInfosResponseBody : TeaModel {
        /// <summary>
        /// 容量信息列表
        /// </summary>
        [NameInMap("quotas")]
        [Validation(Required=false)]
        public List<GetQuotaInfosResponseBodyQuotas> Quotas { get; set; }
        public class GetQuotaInfosResponseBodyQuotas : TeaModel {
            /// <summary>
            /// 容量类型
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 容量标识符
            /// </summary>
            [NameInMap("identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// 总容量
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// 已使用容量
            /// </summary>
            [NameInMap("usedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

    }

}
