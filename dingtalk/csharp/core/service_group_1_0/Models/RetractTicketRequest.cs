// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class RetractTicketRequest : TeaModel {
        [NameInMap("notify")]
        [Validation(Required=false)]
        public RetractTicketRequestNotify Notify { get; set; }
        public class RetractTicketRequestNotify : TeaModel {
            [NameInMap("groupNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> GroupNoticeReceiverUnionIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("noticeAllGroupMember")]
            [Validation(Required=false)]
            public bool? NoticeAllGroupMember { get; set; }

            [NameInMap("workNoticeReceiverUnionIds")]
            [Validation(Required=false)]
            public List<string> WorkNoticeReceiverUnionIds { get; set; }

        }

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

        [NameInMap("operatorUnionId")]
        [Validation(Required=false)]
        public string OperatorUnionId { get; set; }

        [NameInMap("ticketMemo")]
        [Validation(Required=false)]
        public RetractTicketRequestTicketMemo TicketMemo { get; set; }
        public class RetractTicketRequestTicketMemo : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<RetractTicketRequestTicketMemoAttachments> Attachments { get; set; }
            public class RetractTicketRequestTicketMemoAttachments : TeaModel {
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

        }

    }

}
