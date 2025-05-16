// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSingleChatOpenConversationIdRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>022*****2134</para>
        /// </summary>
        [NameInMap("userId1")]
        [Validation(Required=false)]
        public string UserId1 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>072*****1243</para>
        /// </summary>
        [NameInMap("userId2")]
        [Validation(Required=false)]
        public string UserId2 { get; set; }

    }

}
