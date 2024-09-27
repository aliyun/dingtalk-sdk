// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class QueryFormInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SWAPP-dfeacds-example</para>
        /// </summary>
        [NameInMap("appUuid")]
        [Validation(Required=false)]
        public string AppUuid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROC-abcdef-example</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>951a8-8828-430c-b3e-example</para>
        /// </summary>
        [NameInMap("formInstanceId")]
        [Validation(Required=false)]
        public string FormInstanceId { get; set; }

    }

}
