// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class PushDingMessageRequest : TeaModel {
        /// <summary>
        /// 应用Id，默认是医疗的应用。
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// 消息内容，长度不超过500。
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// 消息类型：CARD:卡片消息；LINK:链接消息；TEXT：文本消息；
        /// </summary>
        [NameInMap("messageType")]
        [Validation(Required=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// 链接消息时，消息文案下的URL。
        /// </summary>
        [NameInMap("messageUrl")]
        [Validation(Required=false)]
        public string MessageUrl { get; set; }

        /// <summary>
        /// 链接消息时，右侧图片URL。
        /// </summary>
        [NameInMap("pictureUrl")]
        [Validation(Required=false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 卡片消息时，消息下面action的标题，长度不超过20。
        /// </summary>
        [NameInMap("singleTitle")]
        [Validation(Required=false)]
        public string SingleTitle { get; set; }

        /// <summary>
        /// 卡片消息时，消息下面action转跳URL，长度不超过500。
        /// </summary>
        [NameInMap("singleUrl")]
        [Validation(Required=false)]
        public string SingleUrl { get; set; }

        /// <summary>
        /// 消息展示标题，长度不超过100。
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 组织下的staffId列表
        /// </summary>
        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
