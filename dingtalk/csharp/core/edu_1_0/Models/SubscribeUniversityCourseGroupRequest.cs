// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class SubscribeUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>DDS10002</para>
        /// </summary>
        [NameInMap("courseGroupCode")]
        [Validation(Required=false)]
        public string CourseGroupCode { get; set; }

        [NameInMap("studentUserIds")]
        [Validation(Required=false)]
        public List<string> StudentUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>manger1234</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
