// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetYongYouOpenApiTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>accounting</para>
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>518400</para>
        /// </summary>
        [NameInMap("expiresIn")]
        [Validation(Required=false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2512799</para>
        /// </summary>
        [NameInMap("refreshExpiresIn")]
        [Validation(Required=false)]
        public string RefreshExpiresIn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("refreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>auth_all</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123615862385832922</para>
        /// </summary>
        [NameInMap("yongyouOrgId")]
        [Validation(Required=false)]
        public string YongyouOrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>391733693750254232</para>
        /// </summary>
        [NameInMap("yongyouUserId")]
        [Validation(Required=false)]
        public string YongyouUserId { get; set; }

    }

}
