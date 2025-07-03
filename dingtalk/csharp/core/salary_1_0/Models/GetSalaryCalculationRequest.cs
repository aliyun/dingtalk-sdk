// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class GetSalaryCalculationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SalaryGroupxxx</para>
        /// </summary>
        [NameInMap("salaryGroupId")]
        [Validation(Required=false)]
        public string SalaryGroupId { get; set; }

    }

}
