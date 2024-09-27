// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessInstanceWithExtraRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a171de6c-8bxxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
