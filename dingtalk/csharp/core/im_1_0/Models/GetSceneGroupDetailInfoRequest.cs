// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetSceneGroupDetailInfoRequest : TeaModel {
        [NameInMap("cool_app_code")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cidXXXXXXX</para>
        /// </summary>
        [NameInMap("open_conversation_id")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
