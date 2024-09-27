// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class TerminateProcessInstanceRequest : TeaModel {
        [NameInMap("isSystem")]
        [Validation(Required=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>133743186427339452</para>
        /// </summary>
        [NameInMap("operatingUserId")]
        [Validation(Required=false)]
        public string OperatingUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a171de6c-8bxxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>终止说明。</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
