// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetConversationDetailResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetConversationDetailResponseBodyResult Result { get; set; }
        public class GetConversationDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("categoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>categoryName</para>
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("groupCode")]
            [Validation(Required=false)]
            public string GroupCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("groupMembersCnt")]
            [Validation(Required=false)]
            public int? GroupMembersCnt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>groupOwnerName</para>
            /// </summary>
            [NameInMap("groupOwnerName")]
            [Validation(Required=false)]
            public string GroupOwnerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>groupOwnerUserId</para>
            /// </summary>
            [NameInMap("groupOwnerUserId")]
            [Validation(Required=false)]
            public string GroupOwnerUserId { get; set; }

            [NameInMap("isKpConversation")]
            [Validation(Required=false)]
            public bool? IsKpConversation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("manageSign")]
            [Validation(Required=false)]
            public int? ManageSign { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cidxxx</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
