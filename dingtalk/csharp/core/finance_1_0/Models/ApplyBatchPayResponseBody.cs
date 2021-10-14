// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayResponseBody : TeaModel {
        /// <summary>
        /// 钉钉支付的批次号
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付确认页数据
        /// </summary>
        [NameInMap("payData")]
        [Validation(Required=false)]
        public string PayData { get; set; }

    }

}
