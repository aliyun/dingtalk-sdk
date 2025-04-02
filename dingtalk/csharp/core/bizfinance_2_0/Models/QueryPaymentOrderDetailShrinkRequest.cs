// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryPaymentOrderDetailShrinkRequest : TeaModel {
        [NameInMap("outBizNoList")]
        [Validation(Required=false)]
        public string OutBizNoListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50455845112</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
