// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_phone_1_0.Models
{
    public class AddCallConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding3f583b067f2q450c12d</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>token12345</para>
        /// </summary>
        [NameInMap("isvToken")]
        [Validation(Required=false)]
        public string IsvToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>057112345678</para>
        /// </summary>
        [NameInMap("phoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>call</para>
        /// </summary>
        [NameInMap("scopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
