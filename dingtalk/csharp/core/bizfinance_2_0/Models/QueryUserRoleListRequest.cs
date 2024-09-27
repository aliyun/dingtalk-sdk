// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryUserRoleListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12312231231</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
