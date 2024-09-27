// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetCorpAccessTokenRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authCorpId")]
        [Validation(Required=false)]
        public string AuthCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("suiteKey")]
        [Validation(Required=false)]
        public string SuiteKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("suiteSecret")]
        [Validation(Required=false)]
        public string SuiteSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("suiteTicket")]
        [Validation(Required=false)]
        public string SuiteTicket { get; set; }

    }

}
