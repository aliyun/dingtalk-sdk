// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryItemRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SalaryItemGroupxxx</para>
        /// </summary>
        [NameInMap("salaryItemGroupId")]
        [Validation(Required=false)]
        public string SalaryItemGroupId { get; set; }

    }

}
