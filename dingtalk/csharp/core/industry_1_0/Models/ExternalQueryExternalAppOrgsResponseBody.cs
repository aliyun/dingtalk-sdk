// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ExternalQueryExternalAppOrgsResponseBody : TeaModel {
        /// <summary>
        /// 返回项目组
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExternalQueryExternalAppOrgsResponseBodyResult> Result { get; set; }
        public class ExternalQueryExternalAppOrgsResponseBodyResult : TeaModel {
            /// <summary>
            /// 外部合作组织ID
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 外部合作组织名称
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

        }

    }

}
