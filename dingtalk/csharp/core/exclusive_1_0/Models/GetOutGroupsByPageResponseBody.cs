// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetOutGroupsByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("responseBody")]
        [Validation(Required=false)]
        public GetOutGroupsByPageResponseBodyResponseBody ResponseBody { get; set; }
        public class GetOutGroupsByPageResponseBodyResponseBody : TeaModel {
            [NameInMap("groupList")]
            [Validation(Required=false)]
            public List<GetOutGroupsByPageResponseBodyResponseBodyGroupList> GroupList { get; set; }
            public class GetOutGroupsByPageResponseBodyResponseBodyGroupList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>{   &quot;text&quot;: {     &quot;content&quot;: &quot;这是一段文本&quot;   } }</para>
                /// </summary>
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

    }

}
