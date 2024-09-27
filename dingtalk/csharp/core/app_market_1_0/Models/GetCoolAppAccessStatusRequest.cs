// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class GetCoolAppAccessStatusRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b195bb70dde337aabf3bcc020bf6250c</para>
        /// </summary>
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COOLAPP-1-1019F4BBC7D6212C5861000T</para>
        /// </summary>
        [NameInMap("coolAppCode")]
        [Validation(Required=false)]
        public string CoolAppCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cid5uZRmigtVWpjcKPLrp5Pag==</para>
        /// </summary>
        [NameInMap("encFieldBizCode")]
        [Validation(Required=false)]
        public string EncFieldBizCode { get; set; }

    }

}
