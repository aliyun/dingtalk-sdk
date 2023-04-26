// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SendContractCardRequest : TeaModel {
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        [NameInMap("contractInfo")]
        [Validation(Required=false)]
        public SendContractCardRequestContractInfo ContractInfo { get; set; }
        public class SendContractCardRequestContractInfo : TeaModel {
            [NameInMap("contractCode")]
            [Validation(Required=false)]
            public string ContractCode { get; set; }

            [NameInMap("contractName")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("signUserName")]
            [Validation(Required=false)]
            public string SignUserName { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("receiveGroups")]
        [Validation(Required=false)]
        public List<string> ReceiveGroups { get; set; }

        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<SendContractCardRequestReceivers> Receivers { get; set; }
        public class SendContractCardRequestReceivers : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        [NameInMap("sender")]
        [Validation(Required=false)]
        public SendContractCardRequestSender Sender { get; set; }
        public class SendContractCardRequestSender : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        [NameInMap("syncSingleChat")]
        [Validation(Required=false)]
        public bool? SyncSingleChat { get; set; }

    }

}
