// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class RuleBatchReceiverRequest : TeaModel {
        [NameInMap("batchNo")]
        [Validation(Required=false)]
        public string BatchNo { get; set; }

        [NameInMap("cardOptions")]
        [Validation(Required=false)]
        public string CardOptions { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<RuleBatchReceiverRequestData> Data { get; set; }
        public class RuleBatchReceiverRequestData : TeaModel {
            [NameInMap("atAccount")]
            [Validation(Required=false)]
            public string AtAccount { get; set; }

            [NameInMap("attrs")]
            [Validation(Required=false)]
            public RuleBatchReceiverRequestDataAttrs Attrs { get; set; }
            public class RuleBatchReceiverRequestDataAttrs : TeaModel {
                [NameInMap("listUnitId")]
                [Validation(Required=false)]
                public List<long?> ListUnitId { get; set; }

            }

            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("cardCallbackUrl")]
            [Validation(Required=false)]
            public string CardCallbackUrl { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public Dictionary<string, Dictionary<string, object>> Content { get; set; }

            [NameInMap("isAtAll")]
            [Validation(Required=false)]
            public bool? IsAtAll { get; set; }

            [NameInMap("receiverAccount")]
            [Validation(Required=false)]
            public string ReceiverAccount { get; set; }

            [NameInMap("receiverType")]
            [Validation(Required=false)]
            public int? ReceiverType { get; set; }

            [NameInMap("serialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

        }

        [NameInMap("ruleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        [NameInMap("secretKey")]
        [Validation(Required=false)]
        public string SecretKey { get; set; }

        [NameInMap("specialStrategy")]
        [Validation(Required=false)]
        public bool? SpecialStrategy { get; set; }

        [NameInMap("taskBatchNo")]
        [Validation(Required=false)]
        public string TaskBatchNo { get; set; }

    }

}
