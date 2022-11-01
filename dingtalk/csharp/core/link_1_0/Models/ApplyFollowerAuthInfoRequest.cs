// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ApplyFollowerAuthInfoRequest : TeaModel {
        /// <summary>
        /// 申请的授权数据，多个数据时使用,分隔。
        /// 暂时仅支持申请手机号码授权：Contact.User.mobile
        /// </summary>
        [NameInMap("fieldScope")]
        [Validation(Required=false)]
        public string FieldScope { get; set; }

        /// <summary>
        /// 服务窗机器人消息sessionId。
        /// 开发者需要接入服务窗自建机器人后通过回调消息获取到的sessionId。
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 服务窗关注用户userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
