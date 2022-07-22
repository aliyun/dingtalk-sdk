// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class ExternalQueryExternalOrgsResponseBody : TeaModel {
        /// <summary>
        /// 返回项目组
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ExternalQueryExternalOrgsResponseBodyResult> Result { get; set; }
        public class ExternalQueryExternalOrgsResponseBodyResult : TeaModel {
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
