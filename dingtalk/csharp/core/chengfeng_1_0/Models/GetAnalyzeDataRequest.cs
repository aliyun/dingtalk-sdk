// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkchengfeng_1_0.Models
{
    public class GetAnalyzeDataRequest : TeaModel {
        [NameInMap("periodIds")]
        [Validation(Required=false)]
        public List<string> PeriodIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32222</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

    }

}
