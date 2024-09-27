// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrgTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1, &quot;省级教育厅&quot;;2, &quot;市级教育局&quot;;3, &quot;区县教育局&quot;;4, &quot;中心校&quot;;5, &quot;普通学校&quot;</para>
        /// </summary>
        [NameInMap("orgType")]
        [Validation(Required=false)]
        public long? OrgType { get; set; }

    }

}
