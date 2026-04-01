// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class SaveSalaryArchivesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>转正</para>
        /// </summary>
        [NameInMap("adjustMemo")]
        [Validation(Required=false)]
        public string AdjustMemo { get; set; }

        [NameInMap("contents")]
        [Validation(Required=false)]
        public List<SaveSalaryArchivesRequestContents> Contents { get; set; }
        public class SaveSalaryArchivesRequestContents : TeaModel {
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
        /// <para>2025-06-01</para>
        /// </summary>
        [NameInMap("effectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user001</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

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
