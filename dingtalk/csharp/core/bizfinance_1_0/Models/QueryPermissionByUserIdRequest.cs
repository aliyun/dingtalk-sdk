// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryPermissionByUserIdRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
