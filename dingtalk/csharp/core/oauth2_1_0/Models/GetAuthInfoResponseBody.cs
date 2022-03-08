// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// 授权应用信息
        /// </summary>
        [NameInMap("authAppInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthAppInfo AuthAppInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthAppInfo : TeaModel {
            [NameInMap("agentList")]
            [Validation(Required=false)]
            public List<GetAuthInfoResponseBodyAuthAppInfoAgentList> AgentList { get; set; }
            public class GetAuthInfoResponseBodyAuthAppInfoAgentList : TeaModel {
                public List<string> AdminList { get; set; }
                public long? AgentId { get; set; }
                public string AgentName { get; set; }
                public long? AppId { get; set; }
            }
        };

        /// <summary>
        /// 应用企业信息
        /// </summary>
        [NameInMap("authCorpInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthCorpInfo AuthCorpInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthCorpInfo : TeaModel {
            [NameInMap("authChannel")]
            [Validation(Required=false)]
            public string AuthChannel { get; set; }
            [NameInMap("authChannelType")]
            [Validation(Required=false)]
            public string AuthChannelType { get; set; }
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public long? AuthLevel { get; set; }
            [NameInMap("corpLogoUrl")]
            [Validation(Required=false)]
            public string CorpLogoUrl { get; set; }
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }
            [NameInMap("inviteCode")]
            [Validation(Required=false)]
            public string InviteCode { get; set; }
            [NameInMap("inviteUrl")]
            [Validation(Required=false)]
            public string InviteUrl { get; set; }
            [NameInMap("licenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }
        };

        /// <summary>
        /// 授权用户信息
        /// </summary>
        [NameInMap("authUserInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthUserInfo AuthUserInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthUserInfo : TeaModel {
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
        };

    }

}
