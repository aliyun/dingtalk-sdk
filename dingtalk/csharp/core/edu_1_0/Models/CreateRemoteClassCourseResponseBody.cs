// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateRemoteClassCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateRemoteClassCourseResponseBodyResult Result { get; set; }
        public class CreateRemoteClassCourseResponseBodyResult : TeaModel {
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
