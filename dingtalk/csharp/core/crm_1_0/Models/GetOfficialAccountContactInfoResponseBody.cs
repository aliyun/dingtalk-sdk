// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactInfoResponseBody : TeaModel {
        [NameInMap("authItems")]
        [Validation(Required=false)]
        public List<string> AuthItems { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>阿里巴巴钉钉</para>
        /// </summary>
        [NameInMap("corpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18812341234</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>+86</para>
        /// </summary>
        [NameInMap("stateCode")]
        [Validation(Required=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>unionId</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        [NameInMap("userInfos")]
        [Validation(Required=false)]
        public List<string> UserInfos { get; set; }

    }

}
