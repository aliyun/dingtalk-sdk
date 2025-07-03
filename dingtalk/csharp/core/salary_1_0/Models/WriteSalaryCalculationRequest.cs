// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class WriteSalaryCalculationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-06</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<WriteSalaryCalculationRequestItems> Items { get; set; }
        public class WriteSalaryCalculationRequestItems : TeaModel {
            [NameInMap("contents")]
            [Validation(Required=false)]
            public List<WriteSalaryCalculationRequestItemsContents> Contents { get; set; }
            public class WriteSalaryCalculationRequestItemsContents : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SalaryItemXXX</para>
                /// </summary>
                [NameInMap("salaryItemId")]
                [Validation(Required=false)]
                public string SalaryItemId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>26</para>
                /// </summary>
                [NameInMap("salaryItemValue")]
                [Validation(Required=false)]
                public string SalaryItemValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
