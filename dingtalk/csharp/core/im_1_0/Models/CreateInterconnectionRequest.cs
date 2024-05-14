// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("interconnections")]
        [Validation(Required=false)]
        public List<CreateInterconnectionRequestInterconnections> Interconnections { get; set; }
        public class CreateInterconnectionRequestInterconnections : TeaModel {
            [NameInMap("appUserAvatar")]
            [Validation(Required=false)]
            public string AppUserAvatar { get; set; }

            [NameInMap("appUserAvatarMediaType")]
            [Validation(Required=false)]
            public int? AppUserAvatarMediaType { get; set; }

            [NameInMap("appUserDynamics")]
            [Validation(Required=false)]
            public string AppUserDynamics { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appUserMobile")]
            [Validation(Required=false)]
            public string AppUserMobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appUserName")]
            [Validation(Required=false)]
            public string AppUserName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("channelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
