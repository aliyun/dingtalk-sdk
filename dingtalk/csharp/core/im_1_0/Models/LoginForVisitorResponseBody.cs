// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class LoginForVisitorResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("aimInfo")]
        [Validation(Required=false)]
        public LoginForVisitorResponseBodyAimInfo AimInfo { get; set; }
        public class LoginForVisitorResponseBodyAimInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app_123456</para>
            /// </summary>
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("appKey")]
            [Validation(Required=false)]
            public Dictionary<string, string> AppKey { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk_app</para>
            /// </summary>
            [NameInMap("appName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("aimToken")]
        [Validation(Required=false)]
        public LoginForVisitorResponseBodyAimToken AimToken { get; set; }
        public class LoginForVisitorResponseBodyAimToken : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc123xyz</para>
            /// </summary>
            [NameInMap("accessToken")]
            [Validation(Required=false)]
            public string AccessToken { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("accessTokenExpiredTime")]
            [Validation(Required=false)]
            public long? AccessTokenExpiredTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1717027200000</para>
            /// </summary>
            [NameInMap("buildTime")]
            [Validation(Required=false)]
            public long? BuildTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>refreshtoken_789</para>
            /// </summary>
            [NameInMap("refreshToken")]
            [Validation(Required=false)]
            public string RefreshToken { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("appUid")]
        [Validation(Required=false)]
        public string AppUid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel_123</para>
        /// </summary>
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device_001</para>
        /// </summary>
        [NameInMap("deviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("safeDomainName")]
        [Validation(Required=false)]
        public string SafeDomainName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("userName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@123456</para>
        /// </summary>
        [NameInMap("visitorAvatar")]
        [Validation(Required=false)]
        public string VisitorAvatar { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/acd123.jpg">https://example.com/acd123.jpg</a></para>
        /// </summary>
        [NameInMap("visitorAvatarUrl")]
        [Validation(Required=false)]
        public string VisitorAvatarUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cid_12345</para>
        /// </summary>
        [NameInMap("visitorCid")]
        [Validation(Required=false)]
        public string VisitorCid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openconversation_12345</para>
        /// </summary>
        [NameInMap("visitorOpenConversationId")]
        [Validation(Required=false)]
        public string VisitorOpenConversationId { get; set; }

    }

}
