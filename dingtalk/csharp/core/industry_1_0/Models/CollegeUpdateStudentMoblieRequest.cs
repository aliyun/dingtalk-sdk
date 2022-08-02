// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeUpdateStudentMoblieRequest : TeaModel {
        /// <summary>
        /// 是否直接更换
        /// </summary>
        [NameInMap("isForce")]
        [Validation(Required=false)]
        public bool? IsForce { get; set; }

        /// <summary>
        /// 修改后的手机号
        /// </summary>
        [NameInMap("newMobile")]
        [Validation(Required=false)]
        public string NewMobile { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

    }

}
