// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupInfoByOpenCidsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<QueryGroupInfoByOpenCidsResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class QueryGroupInfoByOpenCidsResponseBodyGroupInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>$2$123456$2</para>
            /// </summary>
            [NameInMap("appCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding1234</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@abc</para>
            /// </summary>
            [NameInMap("groupAvatar")]
            [Validation(Required=false)]
            public string GroupAvatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://abc">https://abc</a></para>
            /// </summary>
            [NameInMap("groupAvatarUrl")]
            [Validation(Required=false)]
            public string GroupAvatarUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>群名称</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456a==</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

    }

}
