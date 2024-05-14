// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("authAppInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthAppInfo AuthAppInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthAppInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("agentList")]
            [Validation(Required=false)]
            public List<GetAuthInfoResponseBodyAuthAppInfoAgentList> AgentList { get; set; }
            public class GetAuthInfoResponseBodyAuthAppInfoAgentList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("adminList")]
                [Validation(Required=false)]
                public List<string> AdminList { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("agentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("authCorpInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthCorpInfo AuthCorpInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthCorpInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("authChannel")]
            [Validation(Required=false)]
            public string AuthChannel { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("authChannelType")]
            [Validation(Required=false)]
            public string AuthChannelType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public long? AuthLevel { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpLogoUrl")]
            [Validation(Required=false)]
            public string CorpLogoUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inviteCode")]
            [Validation(Required=false)]
            public string InviteCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inviteUrl")]
            [Validation(Required=false)]
            public string InviteUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("licenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("authUserInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthUserInfo AuthUserInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthUserInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
