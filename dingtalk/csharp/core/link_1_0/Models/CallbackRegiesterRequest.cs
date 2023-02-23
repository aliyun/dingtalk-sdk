// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CallbackRegiesterRequest : TeaModel {
        /// <summary>
        /// 回调API签名生成密钥。
        /// 最大长度不超过32个字符。
        /// </summary>
        [NameInMap("apiSecret")]
        [Validation(Required=false)]
        public string ApiSecret { get; set; }

        /// <summary>
        /// 回调key，由调用者定义，需要确保同一服务窗帐号下的唯一性。
        /// 最长不超过32个字符。
        /// </summary>
        [NameInMap("callbackKey")]
        [Validation(Required=false)]
        public string CallbackKey { get; set; }

        /// <summary>
        /// 回调URL。暂不支持附带queryString的URL
        /// </summary>
        [NameInMap("callbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 回调类型，支持互动卡片、应用快捷入口、吊顶卡片等。
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
