// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GetConversationUrlRequest : TeaModel {
        /// <summary>
        /// C端用户在业务账号体系内的用户userid，长度限制为1~64个字符。
        /// </summary>
        [NameInMap("appUserId")]
        [Validation(Required=false)]
        public string AppUserId { get; set; }

        /// <summary>
        /// C端客户渠道code。
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 群会话Id。
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// C端客户标识。
        /// </summary>
        [NameInMap("sourceCode")]
        [Validation(Required=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// B端用户的钉钉userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
