// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SendContractCardRequest : TeaModel {
        /// <summary>
        /// 卡片类型
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        /// <summary>
        /// 合同信息
        /// </summary>
        [NameInMap("contractInfo")]
        [Validation(Required=false)]
        public SendContractCardRequestContractInfo ContractInfo { get; set; }
        public class SendContractCardRequestContractInfo : TeaModel {
            /// <summary>
            /// 合同编号
            /// </summary>
            [NameInMap("contractCode")]
            [Validation(Required=false)]
            public string ContractCode { get; set; }

            /// <summary>
            /// 合同名称
            /// </summary>
            [NameInMap("contractName")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            /// <summary>
            /// 签署时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// 签署人名称
            /// </summary>
            [NameInMap("signUserName")]
            [Validation(Required=false)]
            public string SignUserName { get; set; }

        }

        /// <summary>
        /// 合同的企业id
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 额外信息
        /// </summary>
        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// 审批实例id
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 接收群id
        /// </summary>
        [NameInMap("receiveGroups")]
        [Validation(Required=false)]
        public List<string> ReceiveGroups { get; set; }

        /// <summary>
        /// 接收者
        /// </summary>
        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<SendContractCardRequestReceivers> Receivers { get; set; }
        public class SendContractCardRequestReceivers : TeaModel {
            /// <summary>
            /// 接收者所在组织
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户类型
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// 发送者
        /// </summary>
        [NameInMap("sender")]
        [Validation(Required=false)]
        public SendContractCardRequestSender Sender { get; set; }
        public class SendContractCardRequestSender : TeaModel {
            /// <summary>
            /// 发起人所在组织
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户类型
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// 是否同步单聊
        /// </summary>
        [NameInMap("syncSingleChat")]
        [Validation(Required=false)]
        public bool? SyncSingleChat { get; set; }

    }

}
