// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models
{
    public class QueryShortcutScopesResponseBody : TeaModel {
        [NameInMap("deptVisibleScopes")]
        [Validation(Required=false)]
        public List<long?> DeptVisibleScopes { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("userVisibleScopes")]
        [Validation(Required=false)]
        public List<string> UserVisibleScopes { get; set; }

    }

}
