// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeOrderRequest : TeaModel {
        /// <summary>
        /// ISV的cropId
        /// </summary>
        [NameInMap("isvCorpId")]
        [Validation(Required=false)]
        public string IsvCorpId { get; set; }

        /// <summary>
        /// 外部商户批次号列表
        /// </summary>
        [NameInMap("outBatchNos")]
        [Validation(Required=false)]
        public List<string> OutBatchNos { get; set; }

        /// <summary>
        /// ISV/企业自建应用suiteId
        /// </summary>
        [NameInMap("suiteId")]
        [Validation(Required=false)]
        public string SuiteId { get; set; }

    }

}
