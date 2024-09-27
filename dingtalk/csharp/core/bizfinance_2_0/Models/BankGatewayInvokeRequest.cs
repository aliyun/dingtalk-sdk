// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BankGatewayInvokeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>bankHttp</para>
        /// </summary>
        [NameInMap("actionType")]
        [Validation(Required=false)]
        public string ActionType { get; set; }

        [NameInMap("inputData")]
        [Validation(Required=false)]
        public string InputData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://cdc.cmbchina.com/cdcserver/api/v2">https://cdc.cmbchina.com/cdcserver/api/v2</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
