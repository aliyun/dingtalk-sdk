// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateSnsAppOrderResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alipay_sdk=alipay-sdk-java-dynamicVersionNo&amp;version=1.0</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M00001</para>
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CM0001</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

    }

}
