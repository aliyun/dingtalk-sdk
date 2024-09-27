// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class SendContractCardRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>signing</para>
        /// </summary>
        [NameInMap("cardType")]
        [Validation(Required=false)]
        public string CardType { get; set; }

        [NameInMap("contractInfo")]
        [Validation(Required=false)]
        public SendContractCardRequestContractInfo ContractInfo { get; set; }
        public class SendContractCardRequestContractInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>HT_xxxxxxx</para>
            /// </summary>
            [NameInMap("contractCode")]
            [Validation(Required=false)]
            public string ContractCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>合同</para>
            /// </summary>
            [NameInMap("contractName")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1242153453</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("signUserName")]
            [Validation(Required=false)]
            public string SignUserName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding5f62ac8a3c24952ebc961a6cb783455b</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC_Xxxxxxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("receiveGroups")]
        [Validation(Required=false)]
        public List<string> ReceiveGroups { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<SendContractCardRequestReceivers> Receivers { get; set; }
        public class SendContractCardRequestReceivers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding5f62ac8a3c24952ebc961a6cb783455b</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1622265907855672</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>可以为空</para>
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sender")]
        [Validation(Required=false)]
        public SendContractCardRequestSender Sender { get; set; }
        public class SendContractCardRequestSender : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ding5f62ac8a3c24952ebc961a6cb783455b</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1622265907855672</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>可以为空</para>
            /// </summary>
            [NameInMap("userType")]
            [Validation(Required=false)]
            public string UserType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("syncSingleChat")]
        [Validation(Required=false)]
        public bool? SyncSingleChat { get; set; }

    }

}
