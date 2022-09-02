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
                /// <summary>
                /// 对此微应用有管理权限的管理员列表
                /// </summary>
                [NameInMap("adminList")]
                [Validation(Required=false)]
                public List<string> AdminList { get; set; }

                /// <summary>
                /// 应用id
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// 应用名称
                /// </summary>
                [NameInMap("agentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// 三方应用id
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

            }

        }

        /// <summary>
        /// 应用企业信息
        /// </summary>
        [NameInMap("authCorpInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthCorpInfo AuthCorpInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthCorpInfo : TeaModel {
            /// <summary>
            /// 渠道码。
            /// </summary>
            [NameInMap("authChannel")]
            [Validation(Required=false)]
            public string AuthChannel { get; set; }

            /// <summary>
            /// 渠道类型。  为了避免渠道码重复，可与渠道码共同确认渠道。可能为空，非空时当前只有满天星类型，值为STAR_ACTIVITY。
            /// </summary>
            [NameInMap("authChannelType")]
            [Validation(Required=false)]
            public string AuthChannelType { get; set; }

            /// <summary>
            /// 企业认证等级：  0：未认证  1：高级认证  2：中级认证  3：初级认证
            /// </summary>
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public long? AuthLevel { get; set; }

            /// <summary>
            /// 企业logo。
            /// </summary>
            [NameInMap("corpLogoUrl")]
            [Validation(Required=false)]
            public string CorpLogoUrl { get; set; }

            /// <summary>
            /// 授权方企业名称。
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// 企业所属行业。
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// 邀请码，只有自己邀请的企业才会返回邀请码，可用该邀请码统计不同渠道的拉新，否则值为空字符串。
            /// </summary>
            [NameInMap("inviteCode")]
            [Validation(Required=false)]
            public string InviteCode { get; set; }

            /// <summary>
            /// 企业邀请链接。
            /// </summary>
            [NameInMap("inviteUrl")]
            [Validation(Required=false)]
            public string InviteUrl { get; set; }

            /// <summary>
            /// 序列号。
            /// </summary>
            [NameInMap("licenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

        }

        /// <summary>
        /// 授权用户信息
        /// </summary>
        [NameInMap("authUserInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthUserInfo AuthUserInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthUserInfo : TeaModel {
            /// <summary>
            /// 授权管理员id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
