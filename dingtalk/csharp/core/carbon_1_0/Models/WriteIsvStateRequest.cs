// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteIsvStateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ISV</para>
        /// </summary>
        [NameInMap("isvName")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20220328</para>
        /// </summary>
        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
