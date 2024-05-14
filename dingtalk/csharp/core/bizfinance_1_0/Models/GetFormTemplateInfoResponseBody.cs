// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetFormTemplateInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("receiptFormTemplateInfoList")]
        [Validation(Required=false)]
        public List<GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList> ReceiptFormTemplateInfoList { get; set; }
        public class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("suiteId")]
            [Validation(Required=false)]
            public string SuiteId { get; set; }

        }

    }

}
