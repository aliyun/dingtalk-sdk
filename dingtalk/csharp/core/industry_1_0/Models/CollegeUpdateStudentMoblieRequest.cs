// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateStudentMoblieRequest : TeaModel {
        [NameInMap("isForce")]
        [Validation(Required=false)]
        public bool? IsForce { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187xxxxxxxx</para>
        /// </summary>
        [NameInMap("newMobile")]
        [Validation(Required=false)]
        public string NewMobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>222222</para>
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

    }

}
