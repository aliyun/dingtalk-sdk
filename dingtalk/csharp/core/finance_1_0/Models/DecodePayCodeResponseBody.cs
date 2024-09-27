// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class DecodePayCodeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2512345678</para>
        /// </summary>
        [NameInMap("alipayCode")]
        [Validation(Required=false)]
        public string AlipayCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>codeIdxxxxx</para>
        /// </summary>
        [NameInMap("codeId")]
        [Validation(Required=false)]
        public string CodeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DT_VISITOR</para>
        /// </summary>
        [NameInMap("codeIdentity")]
        [Validation(Required=false)]
        public string CodeIdentity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PURE_IDENTIFY_CODE</para>
        /// </summary>
        [NameInMap("codeType")]
        [Validation(Required=false)]
        public string CodeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding1234</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;authRules&quot;:{}}</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("outBizId")]
        [Validation(Required=false)]
        public string OutBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INTERNAL_STAFF</para>
        /// </summary>
        [NameInMap("userCorpRelationType")]
        [Validation(Required=false)]
        public string UserCorpRelationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>staffId</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("userInCorp")]
        [Validation(Required=false)]
        public bool? UserInCorp { get; set; }

    }

}
