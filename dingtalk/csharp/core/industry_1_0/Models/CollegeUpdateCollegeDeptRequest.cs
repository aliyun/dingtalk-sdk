// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateCollegeDeptRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("sortFactor")]
        [Validation(Required=false)]
        public long? SortFactor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22222</para>
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

    }

}
