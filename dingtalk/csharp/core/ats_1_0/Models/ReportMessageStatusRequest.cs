// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class ReportMessageStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>corp-ABC-prd</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INVALID_USER</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>无效用户</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>594c5b30-57bd-4001-8903-4dc64cdc6739</para>
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AppUid@Channel</para>
        /// </summary>
        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AppUid@Channel</para>
        /// </summary>
        [NameInMap("senderUserId")]
        [Validation(Required=false)]
        public string SenderUserId { get; set; }

    }

}
