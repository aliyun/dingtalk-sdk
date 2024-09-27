// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddTicketMemoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eKWh3GBwsKEiE</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8iS4X94TgtgiE</para>
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dq9hP8Sk2v6vQ6l05nCe5wiEiE</para>
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public AddTicketMemoRequestTicketMemo TicketMemo { get; set; }
        public class AddTicketMemoRequestTicketMemo : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<AddTicketMemoRequestTicketMemoAttachments> Attachments { get; set; }
            public class AddTicketMemoRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>wahaha.txt</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

    }

}
