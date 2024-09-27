// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_phone_1_0.Models
{
    public class DelCallConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ding3f583b067250d34dd</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>token1233143</para>
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

    }

}
