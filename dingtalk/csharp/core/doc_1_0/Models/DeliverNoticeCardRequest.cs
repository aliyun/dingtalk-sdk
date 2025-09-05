// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class DeliverNoticeCardRequest : TeaModel {
        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("btnActionStr")]
        [Validation(Required=false)]
        public Dictionary<string, string> BtnActionStr { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("detailMobileUrl")]
        [Validation(Required=false)]
        public string DetailMobileUrl { get; set; }

        [NameInMap("detailPcUrl")]
        [Validation(Required=false)]
        public string DetailPcUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("lastMessageI18n")]
        [Validation(Required=false)]
        public Dictionary<string, string> LastMessageI18n { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>receiver_id</para>
        /// </summary>
        [NameInMap("receiverId")]
        [Validation(Required=false)]
        public string ReceiverId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user/chat</para>
        /// </summary>
        [NameInMap("receiverType")]
        [Validation(Required=false)]
        public string ReceiverType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
