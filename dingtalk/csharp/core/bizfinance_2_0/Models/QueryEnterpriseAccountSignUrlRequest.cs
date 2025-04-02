// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryEnterpriseAccountSignUrlRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACC_X12133</para>
        /// </summary>
        [NameInMap("accountCode")]
        [Validation(Required=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5041145245</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
