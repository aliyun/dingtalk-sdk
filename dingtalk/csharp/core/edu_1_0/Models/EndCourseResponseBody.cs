// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EndCourseResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("universityCourseCommonResponse")]
        [Validation(Required=false)]
        public EndCourseResponseBodyUniversityCourseCommonResponse UniversityCourseCommonResponse { get; set; }
        public class EndCourseResponseBodyUniversityCourseCommonResponse : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCourseCode</para>
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
