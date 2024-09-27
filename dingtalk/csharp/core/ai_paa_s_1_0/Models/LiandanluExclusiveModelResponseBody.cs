// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_paa_s_1_0.Models
{
    public class LiandanluExclusiveModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>requestId_123</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{        &quot;content&quot;:&quot;OKR 全称为 Objective and Key Results，即目标与关键结果法，是一套明确和跟踪目标及其完成情况的管理工具和方法。&quot;   }</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
