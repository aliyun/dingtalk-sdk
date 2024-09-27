// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-BEFC22B7-EA64-4336-86EB-AB773AA2EB12</para>
        /// </summary>
        [NameInMap("procCode")]
        [Validation(Required=false)]
        public string ProcCode { get; set; }

    }

}
