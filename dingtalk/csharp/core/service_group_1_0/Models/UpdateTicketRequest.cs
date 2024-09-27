// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpdateTicketRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;identifier&quot;:&quot;input1&quot;,&quot;value&quot;:&quot;openAPI更新了值&quot;}]</para>
        /// </summary>
        [NameInMap("customFields")]
        [Validation(Required=false)]
        public string CustomFields { get; set; }

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
        /// <para>iPFWCyMGWPiiIiE</para>
        /// </summary>
        [NameInMap("openTicketId")]
        [Validation(Required=false)]
        public string OpenTicketId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p8VdSjm884SvQ6l05nCe5wiEiE</para>
        /// </summary>
        [NameInMap("processorUnionId")]
        [Validation(Required=false)]
        public string ProcessorUnionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public UpdateTicketRequestTicketMemo TicketMemo { get; set; }
        public class UpdateTicketRequestTicketMemo : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<UpdateTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class UpdateTicketRequestTicketMemoAttachments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>wahaha.txt</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt</para>
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
