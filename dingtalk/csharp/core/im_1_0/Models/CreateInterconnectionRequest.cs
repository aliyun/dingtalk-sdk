// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class CreateInterconnectionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("interconnections")]
        [Validation(Required=false)]
        public List<CreateInterconnectionRequestInterconnections> Interconnections { get; set; }
        public class CreateInterconnectionRequestInterconnections : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>http://***.png</para>
            /// </summary>
            [NameInMap("appUserAvatar")]
            [Validation(Required=false)]
            public string AppUserAvatar { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appUserAvatarMediaType")]
            [Validation(Required=false)]
            public int? AppUserAvatarMediaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>认真工作,快乐生活</para>
            /// </summary>
            [NameInMap("appUserDynamics")]
            [Validation(Required=false)]
            public string AppUserDynamics { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1107****2120</para>
            /// </summary>
            [NameInMap("appUserId")]
            [Validation(Required=false)]
            public string AppUserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188****8655</para>
            /// </summary>
            [NameInMap("appUserMobile")]
            [Validation(Required=false)]
            public string AppUserMobile { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Foo</para>
            /// </summary>
            [NameInMap("appUserName")]
            [Validation(Required=false)]
            public string AppUserName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("channelCode")]
            [Validation(Required=false)]
            public string ChannelCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1745****8777</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
