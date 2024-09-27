// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class PreventCheatingCheckRiskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.3.30</para>
        /// </summary>
        [NameInMap("clientVer")]
        [Validation(Required=false)]
        public string ClientVer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iOS</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("platformVer")]
        [Validation(Required=false)]
        public string PlatformVer { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;lbsWuaToken&quot;: &quot;lbsWua&quot;,&quot;ddSec&quot;:&quot;ddSec&quot;}</para>
        /// </summary>
        [NameInMap("sec")]
        [Validation(Required=false)]
        public string Sec { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
