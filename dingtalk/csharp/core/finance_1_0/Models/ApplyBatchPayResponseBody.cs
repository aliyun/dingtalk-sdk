// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210909153300000002734753314700</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>payData</para>
        /// </summary>
        [NameInMap("payData")]
        [Validation(Required=false)]
        public string PayData { get; set; }

    }

}
