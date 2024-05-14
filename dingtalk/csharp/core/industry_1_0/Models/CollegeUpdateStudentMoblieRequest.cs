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
        /// This parameter is required.
        /// </summary>
        [NameInMap("newMobile")]
        [Validation(Required=false)]
        public string NewMobile { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

    }

}
