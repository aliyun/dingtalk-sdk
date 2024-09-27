// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class SyncChannelMessageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ddats</para>
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Corp-ABC-prd</para>
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;msgtype&quot;:&quot;text&quot;,&quot;text&quot;:{&quot;content&quot;:&quot;月会通知&quot;}}</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1667964772048</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

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

        /// <summary>
        /// <b>Example:</b>
        /// <para>594c5b30-57bd-4001-8903-4dc64cdc6739</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
