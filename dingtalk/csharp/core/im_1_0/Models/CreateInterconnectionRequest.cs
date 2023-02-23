// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionRequest : TeaModel {
        /// <summary>
        /// 要创建的钉外账号列表。
        /// </summary>
        [NameInMap("interconnections")]
        [Validation(Required=false)]
        public List<CreateInterconnectionRequestInterconnections> Interconnections { get; set; }
        public class CreateInterconnectionRequestInterconnections : TeaModel {
            /// <summary>
            /// 钉外账号头像链接。
            /// </summary>
            [NameInMap("appUserAvatar")]
            [Validation(Required=false)]
            public string AppUserAvatar { get; set; }

            /// <summary>
            /// 钉外账号头像类型，取值：
            /// 1（http类型）
            /// </summary>
            [NameInMap("appUserAvatarMediaType")]
            [Validation(Required=false)]
            public int? AppUserAvatarMediaType { get; set; }

            /// <summary>
            /// 钉外账号用户动态，例如：认真工作，快乐生活。
            /// </summary>
            [NameInMap("appUserDynamics")]
            [Validation(Required=false)]
            public string AppUserDynamics { get; set; }

            /// <summary>
            /// 钉外账号在业务系统内的唯一标识。
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// 钉外账号手机号，例如：188****8655。
            /// </summary>
            [NameInMap("appUserMobile")]
            [Validation(Required=false)]
            public string AppUserMobile { get; set; }

            /// <summary>
            /// 钉外账号名称。
            /// </summary>
            [NameInMap("appUserName")]
            [Validation(Required=false)]
            public string AppUserName { get; set; }

            /// <summary>
            /// 渠道code。
            /// </summary>
            [NameInMap("channelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// 钉内账号userId。
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
