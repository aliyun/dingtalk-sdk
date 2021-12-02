// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetReceiptResponseBody : TeaModel {
        /// <summary>
        /// 数据来源于开放时，对应的微应用id
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 单据数据体json
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// 数据模型id
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// 数据来源：审批(approval)，开放接口(openapi)
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
