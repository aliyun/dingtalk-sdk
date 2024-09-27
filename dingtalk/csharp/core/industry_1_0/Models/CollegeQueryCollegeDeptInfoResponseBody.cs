// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeQueryCollegeDeptInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>01123</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>三年二班</para>
        /// </summary>
        [NameInMap("deptName")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>class</para>
        /// </summary>
        [NameInMap("deptType")]
        [Validation(Required=false)]
        public string DeptType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sortFactor")]
        [Validation(Required=false)]
        public long? SortFactor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0123123</para>
        /// </summary>
        [NameInMap("superId")]
        [Validation(Required=false)]
        public long? SuperId { get; set; }

    }

}
