// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetAuthInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authAppInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthAppInfo AuthAppInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthAppInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("agentList")]
            [Validation(Required=false)]
            public List<GetAuthInfoResponseBodyAuthAppInfoAgentList> AgentList { get; set; }
            public class GetAuthInfoResponseBodyAuthAppInfoAgentList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("adminList")]
                [Validation(Required=false)]
                public List<string> AdminList { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>835880322</para>
                /// </summary>
                [NameInMap("agentId")]
                [Validation(Required=false)]
                public long? AgentId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小程序DEMO</para>
                /// </summary>
                [NameInMap("agentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("appId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authCorpInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthCorpInfo AuthCorpInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthCorpInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("authChannel")]
            [Validation(Required=false)]
            public string AuthChannel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("authChannelType")]
            [Validation(Required=false)]
            public string AuthChannelType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("authLevel")]
            [Validation(Required=false)]
            public long? AuthLevel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://static-legacy.dingtalk.com/xxx">https://static-legacy.dingtalk.com/xxx</a></para>
            /// </summary>
            [NameInMap("corpLogoUrl")]
            [Validation(Required=false)]
            public string CorpLogoUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>小程序体验HTTP</para>
            /// </summary>
            [NameInMap("corpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201</para>
            /// </summary>
            [NameInMap("industry")]
            [Validation(Required=false)]
            public string Industry { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("inviteCode")]
            [Validation(Required=false)]
            public string InviteCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://wx.dingtalk.com/invite-page/xxx">https://wx.dingtalk.com/invite-page/xxx</a></para>
            /// </summary>
            [NameInMap("inviteUrl")]
            [Validation(Required=false)]
            public string InviteUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("licenseCode")]
            [Validation(Required=false)]
            public string LicenseCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authUserInfo")]
        [Validation(Required=false)]
        public GetAuthInfoResponseBodyAuthUserInfo AuthUserInfo { get; set; }
        public class GetAuthInfoResponseBodyAuthUserInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manager975</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
