// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionRequest : TeaModel {
        /// <summary>
        /// bc关系列表
        /// </summary>
        [NameInMap("interconnections")]
        [Validation(Required=false)]
        public List<CreateInterconnectionRequestInterconnections> Interconnections { get; set; }
        public class CreateInterconnectionRequestInterconnections : TeaModel {
            /// <summary>
            /// 客户头像链接
            /// </summary>
            [NameInMap("appUserAvatar")]
            [Validation(Required=false)]
            public string AppUserAvatar { get; set; }

            /// <summary>
            /// 客户头像类型，取值：
            /// 1：http
            /// </summary>
            [NameInMap("appUserAvatarMediaType")]
            [Validation(Required=false)]
            public int? AppUserAvatarMediaType { get; set; }

            /// <summary>
            /// 客户动态
            /// </summary>
            [NameInMap("appUserDynamics")]
            [Validation(Required=false)]
            public string AppUserDynamics { get; set; }

            /// <summary>
            /// 客户业务系统唯一标识
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 客户手机号
            /// </summary>
            [NameInMap("appUserMobile")]
            [Validation(Required=false)]
            public string AppUserMobile { get; set; }

            /// <summary>
            /// 客户名称
            /// </summary>
            [NameInMap("appUserName")]
            [Validation(Required=false)]
            public string AppUserName { get; set; }

            /// <summary>
            /// 客户渠道code
            /// </summary>
            [NameInMap("channelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// 客服钉钉Id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 参数签名
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

    }

}
