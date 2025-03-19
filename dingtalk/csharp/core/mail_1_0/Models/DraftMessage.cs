// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmail_1_0.Models
{
    public class DraftMessage : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bccRecipients")]
        [Validation(Required=false)]
        public List<Recipient> BccRecipients { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public DraftMessageBody Body { get; set; }
        public class DraftMessageBody : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bodyHtml")]
            [Validation(Required=false)]
            public Stream BodyHtml { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("bodyText")]
            [Validation(Required=false)]
            public Stream BodyText { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ccRecipients")]
        [Validation(Required=false)]
        public List<Recipient> CcRecipients { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public Recipient From { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("internetMessageHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, object> InternetMessageHeaders { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:uniqid@dingtalk.com">uniqid@dingtalk.com</a></para>
        /// </summary>
        [NameInMap("internetMessageId")]
        [Validation(Required=false)]
        public Stream InternetMessageId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isReadReceiptRequested")]
        [Validation(Required=false)]
        public bool? IsReadReceiptRequested { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRY_NORMAL</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public Stream Priority { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("replyTo")]
        [Validation(Required=false)]
        public Recipient ReplyTo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>主题</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public Stream Subject { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("summary")]
        [Validation(Required=false)]
        public Stream Summary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Stream> Tags { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("toRecipients")]
        [Validation(Required=false)]
        public List<Recipient> ToRecipients { get; set; }

    }

}
