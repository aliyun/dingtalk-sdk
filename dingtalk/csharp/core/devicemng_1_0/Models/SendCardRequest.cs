// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class SendCardRequest : TeaModel {
        /// <summary>
        /// 卡片实例唯一标识
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 卡片变量赋值，json结构
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// 设备业务标识
        /// </summary>
        [NameInMap("deviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        /// <summary>
        /// 设备uuid，唯一标识
        /// </summary>
        [NameInMap("deviceUuid")]
        [Validation(Required=false)]
        public string DeviceUuid { get; set; }

        /// <summary>
        /// 群id，群的唯一标识
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 卡片模板唯一标识，开放平台获取
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 是否为吊顶卡片
        /// </summary>
        [NameInMap("topbox")]
        [Validation(Required=false)]
        public bool? Topbox { get; set; }

        /// <summary>
        /// 用户通讯录唯一标识
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
